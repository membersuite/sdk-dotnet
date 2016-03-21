using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemberSuite.SDK.Utilities
{
    public static class Binary
    {
        public static T Deserialize<T>(byte[] serializedObject)
        {
            using (var ms = new MemoryStream(serializedObject))
                return (T) new BinaryFormatter().Deserialize(ms);
        }

        public static byte[] Serialize(object obj)
        {
            using (var ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static T Clone<T>(T objToCopy)
        {
            return Deserialize<T>(Serialize(objToCopy));
        }
    }
}