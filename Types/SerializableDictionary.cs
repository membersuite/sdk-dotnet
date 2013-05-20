using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    /// PHASE THIS OUT!!!  A custom serializable dictionary IS NOT a standard implementations therefore a SOAP client has NO IDEA how to deserialize the XML into any object
    /// <summary>
    /// Serializable Dictionay class written by Paul Welter, copied from
    /// http://weblogs.asp.net/pwelter34/archive/2006/05/03/444961.aspx
    /// </summary>
    /// <typeparam name="TKey">The type of the key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    /// <remarks>This class was copied verbatim from Paul Welter's blog.</remarks>
    [XmlRoot(ElementName = "dictionary", Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    public class SerializableDictionary<TKey, TValue>
        : Dictionary<TKey, TValue>, IXmlSerializable
    {
        public SerializableDictionary()
        {
        }

        protected SerializableDictionary(SerializationInfo info, StreamingContext context) : base(info, context) { }

        #region IXmlSerializable Members

        public XmlSchema GetSchema()
        {
            return null;
        }


        public void ReadXml(XmlReader reader)
        {
            var keySerializer = new XmlSerializer(typeof (TKey));

            var valueSerializer = new XmlSerializer(typeof (TValue));


            bool wasEmpty = reader.IsEmptyElement;

            reader.Read();


            if (wasEmpty)

                return;


            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement("item");


                reader.ReadStartElement("key");

                var key = (TKey) keySerializer.Deserialize(reader);

                reader.ReadEndElement();


                reader.ReadStartElement("value");

                var value = (TValue) valueSerializer.Deserialize(reader);

                reader.ReadEndElement();


                Add(key, value);


                reader.ReadEndElement();

                reader.MoveToContent();
            }

            reader.ReadEndElement();
        }


        public void WriteXml(XmlWriter writer)
        {
            var keySerializer = new XmlSerializer(typeof (TKey));

            var valueSerializer = new XmlSerializer(typeof (TValue));


            foreach (TKey key in Keys)
            {
                writer.WriteStartElement("item");


                writer.WriteStartElement("key");

                keySerializer.Serialize(writer, key);

                writer.WriteEndElement();


                writer.WriteStartElement("value");

                TValue value = this[key];

                if (value is byte[])
                    value = (TValue) (object) Convert.ToBase64String( (byte[]) (object) value);

                valueSerializer.Serialize(writer, value);

                writer.WriteEndElement();


                writer.WriteEndElement();
            }
        }

        #endregion
    }
}