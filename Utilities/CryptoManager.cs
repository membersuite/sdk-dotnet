using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MemberSuite.SDK.Utilities
{
    public class CryptoManager
    {
        static CryptoManager()
        {
            //Generate the Rijndael key/IV pair to use to encrypt/decrypt data during the life of the executing process
            GenerateProcessSymmetric();
        }

        /// <summary>
        ///     Creates a new instance of the RijndaelManaged provider using random key/IV values that exist during the life of the
        ///     executing process.
        /// </summary>
        /// <returns></returns>
        private static RijndaelManaged GetProcessSymetricProvider()
        {
            var result = new RijndaelManaged();

            //Create pointers to the encrypted data in the SecureStrings used to store the key and IV values
            var keyPointer = Marshal.SecureStringToBSTR(EncryptedProcessSymmetricKey);
            var ivPointer = Marshal.SecureStringToBSTR(EncryptedProcessSymmetricIV);

            //Always access securedstring in a try/finally to clean up the pointers
            try
            {
                //Decrypt the key and IV and set it on the RijndaelManaged symmetric provider
                result.Key = Convert.FromBase64String(Marshal.PtrToStringBSTR(keyPointer));
                result.IV = Convert.FromBase64String(Marshal.PtrToStringBSTR(ivPointer));
            }
            finally
            {
                //IMPORTANT - always free the pointer to the secured data
                Marshal.ZeroFreeBSTR(keyPointer);
                Marshal.ZeroFreeBSTR(ivPointer);
            }

            return result;
        }

        /// <summary>
        ///     Retrieves a X509 Certificate from the Local Machine certificate store using the given store and subject. This
        ///     method attempts to match on the certificate subject
        ///     which is less unique than thumbprint but does not require settings to be reconfigured if the certificate is
        ///     regenerated.
        /// </summary>
        /// <param name="subject">The subject of the certificate to retrieve (usually starts with CN=)</param>
        /// <param name="store">Optional store location of certificates</param>
        /// <returns></returns>
        public static X509Certificate2 GetCertificateByStoreAndSubject(string subject, string store)
        {
            //Determine the store to use - always LocalMachine but the store name may be configured
            var certStore = string.IsNullOrWhiteSpace(store)
                ? new X509Store(StoreLocation.LocalMachine)
                : new X509Store(store, StoreLocation.LocalMachine);
            certStore.Open(OpenFlags.ReadOnly);

            //Not a keyed collection so query on the subject name using LINQ
            var result =
                certStore.Certificates.Cast<X509Certificate2>().FirstOrDefault(
                    currentCert => currentCert.Subject.Equals(subject));
            if (result == null)
                throw new ApplicationException(
                    string.Format("Unable to locate certificate with Container Name '{0}' in Store {1}", subject,
                        certStore.Name));

            return result;
        }

        /// <summary>
        ///     Attempts to use the supplied public key to verify the supplied digital signature against the supplied data.  Will
        ///     attempt to use RSA using SHA1 first then will attempt DSA.
        /// </summary>
        /// <param name="data">The data to use to verify the signature</param>
        /// <param name="signature">The signature to verify</param>
        /// <param name="key">The PublicKey to use to verify the data.</param>
        /// <returns>
        ///     True if the supplied signature was generated using the private key pair of the supplied public key against the
        ///     supplied data. Otherwise false.
        /// </returns>
        public static bool VerifySignature(byte[] data, byte[] signature, PublicKey key)
        {
            return VerifySignature(data, signature, key.Key);
        }

        /// <summary>
        ///     Attempts to use the supplied certificate to verify the supplied digital signature against the supplied data.  Will
        ///     verify with the public key always as it should have been signed with the private key.
        /// </summary>
        /// <param name="data">The data to use to verify the signature</param>
        /// <param name="signature">The signature to verify</param>
        /// <param name="certificate">The certificate containing the PublicKey to use to verify the data.</param>
        /// <returns>
        ///     True if the supplied signature was generated using the private key pair of the supplied public key against the
        ///     supplied data. Otherwise false.
        /// </returns>
        public static bool VerifySignature(byte[] data, byte[] signature, X509Certificate2 certificate)
        {
            return VerifySignature(data, signature, certificate.PublicKey);
        }

        /// <summary>
        ///     Attempts to use the supplied public key to verify the supplied digital signature against the supplied data.  Will
        ///     attempt to use RSA using SHA1 first then will attempt DSA.
        /// </summary>
        /// <param name="data">The data to use to verify the signature</param>
        /// <param name="signature">The signature to verify</param>
        /// <param name="key">The PublicKey to use to verify the data.</param>
        /// <returns>
        ///     True if the supplied signature was generated using the private key pair of the supplied public key against the
        ///     supplied data. Otherwise false.
        /// </returns>
        public static bool VerifySignature(byte[] data, byte[] signature, AsymmetricAlgorithm key)
        {
            if (data == null || data.Length == 0)
                return false;

            if (signature == null || signature.Length == 0)
                return false;

            if (key == null)
                throw new ArgumentNullException("key", "Signature cannot be verified with a null key");

            //Try RSA fist because it's the default when creating a new certificate
            var RSASigner = key as RSACryptoServiceProvider;
            if (RSASigner != null)
                //Currently only supports the certifiacte default SHA1 - to change in the future we'll need a variable
                return RSASigner.VerifyData(data, new SHA1CryptoServiceProvider(), signature);

            //The public key is not using RSA - try DSA
            var DSASigner = key as DSACryptoServiceProvider;
            if (DSASigner != null)
                return DSASigner.VerifyData(data, signature);

            throw new ApplicationException(
                "Unsupported public key algorithm.  Only RSA (default) and DSA are supported.");
        }

        /// <summary>
        ///     Attempts to use the supplied public key to verify the supplied digital signature against the supplied data.  Will
        ///     attempt to use RSA using SHA1 first then will attempt DSA.
        /// </summary>
        /// <param name="data">The data to use to verify the signature</param>
        /// <param name="signature">The signature to verify</param>
        /// <param name="signer">The signer to use to verify the data.</param>
        /// <returns>
        ///     True if the supplied signature was generated using the private key pair of the supplied public key against the
        ///     supplied data. Otherwise false.
        /// </returns>
        public static bool VerifySignature(byte[] data, byte[] signature, RSACryptoServiceProvider signer)
        {
            if (data == null || data.Length == 0)
                return false;

            if (signature == null || signature.Length == 0)
                return false;

            if (signer == null)
                throw new ArgumentNullException("Signature cannot be verified with a null signer");

            //Currently only supports the certifiacte default SHA1 - to change in the future we'll need a variable
            return signer.VerifyData(data, new SHA1CryptoServiceProvider(), signature);
        }

        /// <summary>
        ///     Retrieves a certificate using the supplied store and subject and creates a unique signature using the data using
        ///     the certificate private key.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="certificateSubject">The subject of the certificate containing the private key to use to sign the data</param>
        /// <param name="certificateStore">
        ///     Optional store location of the certificate containing the private key to use to sign the
        ///     data
        /// </param>
        /// <returns></returns>
        public static byte[] Sign(byte[] data, string certificateSubject, string certificateStore)
        {
            var certificate = GetCertificateByStoreAndSubject(certificateSubject, certificateStore);
            return Sign(data, certificate.PrivateKey);
        }

        /// <summary>
        ///     Creates a unique signature using the supplied data and private key of the supplied certificate.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="certificate">The certificate containing the private key to use to sign the data</param>
        /// <returns></returns>
        public static byte[] Sign(byte[] data, X509Certificate2 certificate)
        {
            return Sign(data, certificate.PrivateKey);
        }

        /// <summary>
        ///     Creates a unique signature using the supplied data and RSA key information in the supplied file path.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="path">Path to a unicode encoded text file containing the RSA key XML string</param>
        /// <returns></returns>
        public static byte[] Sign(byte[] data, string path)
        {
            return Sign(data, path, Encoding.Unicode);
        }

        /// <summary>
        ///     Creates a unique signature using the supplied data and RSA key information in the supplied stream.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="xmlKeyStream">A stream containing the RSA key XML string</param>
        /// <param name="encoding">Encoding to use to read the stream</param>
        /// <returns></returns>
        public static byte[] Sign(byte[] data, Stream xmlKeyStream, Encoding encoding)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException("data");

            if (xmlKeyStream == null)
                throw new ArgumentNullException("xmlKeyStream");

            var reader = new StreamReader(xmlKeyStream, encoding);
            var xmlKeyString = reader.ReadToEnd();
            var signer = new RSACryptoServiceProvider();
            signer.FromXmlString(xmlKeyString);
            return signer.SignData(data, new SHA1CryptoServiceProvider());
        }

        /// <summary>
        ///     Creates a unique signature using the supplied data and RSA key information in the supplied stream.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="xmlKeyStream">A stream containing the RSA key XML string</param>
        /// <returns></returns>
        public static byte[] Sign(byte[] data, Stream xmlKeyStream)
        {
            return Sign(data, xmlKeyStream, Encoding.Unicode);
        }

        /// <summary>
        ///     Creates a unique signature using the supplied data and RSA key information in the supplied file path.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="path">Path to a text file containing the RSA key XML string</param>
        /// <param name="encoding">The encoding type for the file contining the RSA key XML string</param>
        /// <returns></returns>
        public static byte[] Sign(byte[] data, string path, Encoding encoding)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException("data");

            if (path == null)
                throw new ArgumentNullException("path");

            var xmlKeyString = File.ReadAllText(path, encoding);
            var signer = new RSACryptoServiceProvider();
            signer.FromXmlString(xmlKeyString);
            return signer.SignData(data, new SHA1CryptoServiceProvider());
        }

        /// <summary>
        ///     Creates a unique signature using the supplied data using the provided key.
        /// </summary>
        /// <param name="data">The data to sign</param>
        /// <param name="key">The RSACryptoServiceProvider or DSACryptoServiceProvider to use to verify the data.</param>
        /// <returns>The unique byte array signature of the data/key combination.</returns>
        public static byte[] Sign(byte[] data, AsymmetricAlgorithm key)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException("data", "The data to sign is required.");

            if (key == null)
                throw new ArgumentNullException("data", "The key to use to sign the data is required.");

            //Try RSA fist because it's the default when creating a new certificate
            var RSASigner = key as RSACryptoServiceProvider;
            if (RSASigner != null)
                //Currently only supports the certifiacte default SHA1 - to change in the future we'll need a variable
                return RSASigner.SignData(data, new SHA1CryptoServiceProvider());

            //The public key is not using RSA - try DSA
            var DSASigner = key as DSACryptoServiceProvider;
            if (DSASigner != null)
                return DSASigner.SignData(data);

            throw new ApplicationException("Unsupported key algorithm.  Only RSA (default) and DSA are supported.");
        }

        /// <summary>
        ///     Generates and encrypts a random symmetric key and IV that are valid for the life of the process.  Generally there
        ///     is no need to call this
        ///     method because values are randomly generated on first use.  However this method can be used to generate a new key
        ///     and IV pair during the life
        ///     of the process.
        ///     **WARNING** executing this method will render all data encrypted using the process symmetric key unretrievable.
        /// </summary>
        public static void GenerateProcessSymmetric()
        {
            EncryptedProcessSymmetricKey = new SecureString();
            EncryptedProcessSymmetricIV = new SecureString();

            //Generate random key/IV settings by creating a new RijndaelManaged instance
            using (var symmetricServiceProvider = new RijndaelManaged())
            {
                //Encrypt the random key to a static variable
                foreach (var c in Convert.ToBase64String(symmetricServiceProvider.Key))
                    EncryptedProcessSymmetricKey.AppendChar(c);
                //Make the static key immutable 
                EncryptedProcessSymmetricKey.MakeReadOnly();

                foreach (var c in Convert.ToBase64String(symmetricServiceProvider.IV))
                    EncryptedProcessSymmetricIV.AppendChar(c);
                //Make the static IV immutable 
                EncryptedProcessSymmetricIV.MakeReadOnly();
            }
        }

        /// <summary>
        ///     Encrypts the supplied data using the Rijndael algorythm and a random key/IV that only exists during the lifespan of
        ///     the executing process.
        ///     **WARNING** restarting the executing process or calling GenerateProcessSymmetric() will render all data encrypted
        ///     using the method unretrievable.
        /// </summary>
        /// <param name="bytes">The data to encrypt</param>
        /// <returns>The encrypted data</returns>
        public static byte[] EncryptDataWithProcessSymmetric(byte[] bytes)
        {
            //Get the Rijndael symmetric provider configured with the static key/IV pair
            using (var symmetricProvider = GetProcessSymetricProvider())
            {
                //Encrypt
                using (var encryptor = symmetricProvider.CreateEncryptor())
                {
                    using (var result = new MemoryStream())
                    {
                        using (var cryptoStream = new CryptoStream(result, encryptor, CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(bytes, 0, bytes.Length);
                            cryptoStream.FlushFinalBlock();
                            return result.ToArray();
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Decrypts data previous encrypted using the Rijndael algorythm and the random key/IV generated during the lifespan
        ///     of the executing process using the EncryptDataWithProcessSymmetric method.
        ///     If the executing process has been restarted or GenerateProcessSymmetric() has been called since the data was
        ///     encrypted this method will fail.
        /// </summary>
        /// <param name="bytes">The data previously encrypted using EncryptDataWithProcessSymmetric</param>
        /// <returns>The decrypted data</returns>
        public static byte[] DecryptDataWithProcessSymmetric(byte[] bytes)
        {
            //Declare the return array - decrypted byte array length cannot be determined
            //but is always smaller than encrypted equivalent data so use the encrypted 
            //array length to avoid out of bounds.
            var result = new byte[bytes.Length];

            //Get the Rijndael symmetric provider configured with the static key/IV pair
            using (var symmetricProvider = GetProcessSymetricProvider())
            {
                //Decrypt
                using (var decryptor = symmetricProvider.CreateDecryptor())
                {
                    using (var memoryStream = new MemoryStream(bytes))
                    {
                        using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            cryptoStream.Read(result, 0, bytes.Length);
                            return result;
                        }
                    }
                }
            }
        }

        public static string GetMessageSignature(byte[] secretAccessKey, string action, string sessionId,
            string associationId)
        {
            HMACSHA1 signer;

            //Always access securedstring in a try/finally to clean up the pointers
            try
            {
                //Decrypt the key and IV and set it on the RijndaelManaged symmetric provider
                signer = new HMACSHA1(secretAccessKey);
            }
            catch (Exception)
            {
                return null;
            }

            return GetMessageSignature(signer, action, sessionId, associationId);
        }

        public static string GetMessageSignature(SecureString secretAccessKey, string action, string sessionId,
            string associationId)
        {
            if (secretAccessKey == null)
                return null;

            HMACSHA1 signer;

            //Create pointers to the encrypted data in the SecureString used to store the secret access key
            var keyPointer = Marshal.SecureStringToBSTR(secretAccessKey);

            //Always access securedstring in a try/finally to clean up the pointers
            try
            {
                //Decrypt the key and IV and set it on the RijndaelManaged symmetric provider
                signer = new HMACSHA1(Convert.FromBase64String(Marshal.PtrToStringBSTR(keyPointer)));
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                //IMPORTANT - always free the pointer to the secured data
                Marshal.ZeroFreeBSTR(keyPointer);
            }

            return GetMessageSignature(signer, action, sessionId, associationId);
        }

        public static string GetMessageSignature(HashAlgorithm signer, string action, string sessionId,
            string associationId)
        {
            if (signer == null)
                return null;

            var dataToSign = action;

            if (!string.IsNullOrWhiteSpace(associationId))
                dataToSign += associationId;

            if (!string.IsNullOrWhiteSpace(sessionId))
                dataToSign += sessionId;

            var signature = signer.ComputeHash(Encoding.ASCII.GetBytes(dataToSign));
            var result = Convert.ToBase64String(signature);

            return result;
        }

        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        public static string GetMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            var md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (var i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        #region Private Static Fields

        /// <summary>
        ///     The encrypted Rijndael key to use during the life of the executing process for process scoped encryption.
        ///     This should always be stored in a SecureString or other encrypted type to minimize the time the clear-text key
        ///     exists in memory.
        /// </summary>
        private static SecureString EncryptedProcessSymmetricKey;

        /// <summary>
        ///     The encrypted Rijndael Initialization Vector (IV) to use during the life of the executing process for process
        ///     scoped encryption.
        ///     This should always be stored in a SecureString or other encrypted type to minimize the time the clear-text IV
        ///     exists in memory.
        /// </summary>
        private static SecureString EncryptedProcessSymmetricIV;

        #endregion
    }
}