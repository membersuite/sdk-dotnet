using System;
using System.IO;
using System.IO.Compression;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public static class CompressionManager
    {
        /// <summary>
        /// Compresses the specified obj to compress.
        /// </summary>
        /// <param name="objToCompress">The obj to compress.</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static byte[] Compress(object objToCompress)
        {
            if (objToCompress == null) throw new ArgumentNullException("objToCompress");

            var bytes = Binary.Serialize( objToCompress );
            MemoryStream ms = new MemoryStream();
            ms.Write( bytes, 0, bytes.Length );

            ms.Position = 0;

            MemoryStream msDestination = new MemoryStream();

            GZipStream gz = new GZipStream(msDestination, CompressionMode.Compress);

            gz.Write(bytes, 0, bytes.Length);
            gz.Close();

            return msDestination.ToArray();
        }

       

        public static object Decompress( byte[] bytesToDecompress)
        {
            if (bytesToDecompress == null) throw new ArgumentNullException("bytesToDecompress");
            using (GZipStream stream = new GZipStream(new MemoryStream(bytesToDecompress), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return Binary.Deserialize<object>( memory.ToArray() );
                }
            }

            
        }
    }
}
