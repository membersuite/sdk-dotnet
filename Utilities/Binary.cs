using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MemberSuite.SDK.Utilities
{
    public static class Binary
    {

        public static T Deserialize<T>(byte[] serializedObject)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream( serializedObject );
            ms.Position = 0;
            return (T) bf.Deserialize(ms);
        }

        public static object Deserialize(byte[] serializedObject)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(serializedObject);
            ms.Position = 0;
            return bf.Deserialize(ms);
        }

        public static byte[] Serialize(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.GetBuffer();
        }

        public static T Clone<T>(T objToCopy)
        {
            return Deserialize<T>(Serialize(objToCopy));
        }
    }
}
