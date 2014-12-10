using System;
using System.IO;
using System.IO.Compression;

namespace MemberSuite.SDK.Utilities
{
    public static class CompressionManager
    {
        public static byte[] Compress(object objToCompress)
        {
            if (objToCompress == null)
                throw new ArgumentNullException("objToCompress");

            var bytes = Binary.Serialize(objToCompress);

            using (var msDestination = new MemoryStream(bytes.Length))
            {
                var gz = new GZipStream(msDestination, CompressionMode.Compress);

                gz.Write(bytes, 0, bytes.Length);
                gz.Close();

                return msDestination.GetBuffer();
            }
        }

        public static object Decompress(Stream source)
        {
            using (var stream = new GZipStream(source, CompressionMode.Decompress))
            {
                const int size = 4096;
                var buffer = new byte[size];
                using (var memory = new MemoryStream())
                {
                    int count;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return Binary.Deserialize<object>(memory.ToArray());
                }
            }
        }

        public static object Decompress(byte[] bytesToDecompress)
        {
            if (bytesToDecompress == null)
                throw new ArgumentNullException("bytesToDecompress");

            return Decompress(new MemoryStream(bytesToDecompress));
        }
    }
}
