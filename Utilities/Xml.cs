// ***********************************************************************
// Assembly         : MemberSuite.SDK
// Author           : Andrew
// Created          : 03-27-2013
//
// Last Modified By : Andrew
// Last Modified On : 03-27-2013
// ***********************************************************************
// <copyright file="Xml.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    /// Class used for Xml serialization/utilieis
    /// </summary>
    public static class Xml
    {



        /// <summary>
        /// Serializes an object with data contract serializer.
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize.</param>
        /// <returns>System.String.</returns>
        public static byte[] SerializeWithDataContractSerializer(object objectToSerialize)
        {
            DataContractSerializer dz = new DataContractSerializer(objectToSerialize.GetType());

            MemoryStream ms = new MemoryStream();
            dz.WriteObject(ms, objectToSerialize);

            return ms.ToArray();
        }



        /// <summary>
        /// Serializes an object with data contract serializer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public static T DeserializeWithDataContractSerializer<T>( string input )
        {
            DataContractSerializer dz = new DataContractSerializer( typeof(T));

            var bytes = Convert.FromBase64String( StringUtil.PadBase64String(input) );
            //var bytes = Convert.FromBase64String(input);
            MemoryStream ms = new MemoryStream( bytes );
            ms.Position = 0;
            
            return (T) dz.ReadObject(ms );

           
        }

        /// <summary>
        /// Serializes the specified object to serialize.
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.ArgumentNullException">objectToSerialize</exception>
        public static string Serialize( object objectToSerialize )
        {
            // pre-conditions

            if ( objectToSerialize == null )
                throw new ArgumentNullException( "objectToSerialize" );

            XmlSerializer xs = new XmlSerializer( objectToSerialize.GetType() );

            StringWriter sw = new StringWriter();
            

            // now, serialize it
            xs.Serialize( sw, objectToSerialize );

            
          
            // and return it!
            return sw.ToString();
        }

        /// <summary>
        /// Deserializes the specified document to serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="documentToSerialize">The document to serialize.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.ArgumentNullException">documentToSerialize</exception>
        public static T Deserialize<T>( XmlNode documentToSerialize )
        {
            // pre-conditions
            if ( documentToSerialize == null )
                throw new ArgumentNullException( "documentToSerialize" );

           

            // we need to use this, because it deals with AnyType properly
            return Deserialize<T>(documentToSerialize.OuterXml);
        }

        /// <summary>
        /// Deserializes the specified document to serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.ArgumentNullException">reader</exception>
        public static T Deserialize<T>(XmlReader reader )
        {
            // pre-conditions
            if (reader == null) throw new ArgumentNullException("reader");

            XmlSerializer xs = new XmlSerializer(typeof(T));
            
            return (T)xs.Deserialize(reader);
           
           
        }

        /// <summary>
        /// Clones the specified obj to copy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objToCopy">The obj to copy.</param>
        /// <returns>``0.</returns>
        public static T Clone<T>(T objToCopy)
        {
            return Deserialize<T>(Serialize(objToCopy));
        }

        /// <summary>
        /// Deserializes the specified document to serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml">The XML.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.ArgumentNullException">xml</exception>
        public static T Deserialize<T>(string xml)
        {
            // pre-conditions
            if (xml == null)
                throw new ArgumentNullException("xml");

            try
            {
                XmlTextReader r = new XmlTextReader(new StringReader(xml));
                return Deserialize<T>(r);
            }
            catch(Exception ex )
            {
                Console.Write("Exception occurred during deserialization: " + ex);
                return default(T); // suppress deserialization errors
            }

        }

        /// <summary>
        /// Generic method for deserializing an object from a XmlDocument
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">XmlDocument containing the Xml to deserialize.</param>
        /// <returns>``0.</returns>
        public static T DeserializeWithNodeReader<T>( XmlNode source)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            object result = serializer.Deserialize( new XmlNodeReader( source) );
           // source.Close();

            return (T) result;
        }



        /// <summary>
        /// Deserializes the specified document to serialize.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="documentToSerialize">The document to serialize.</param>
        /// <returns>``0.</returns>
        /// <exception cref="System.ArgumentNullException">documentToSerialize</exception>
        public static T Deserialize<T>(XContainer documentToSerialize)
        {
            // pre-conditions
            if (documentToSerialize == null)
                throw new ArgumentNullException("documentToSerialize");

            XmlSerializer xs = new XmlSerializer(typeof(T));

            var xnr = documentToSerialize.CreateReader();

            return (T)xs.Deserialize(xnr);
        }

        /// <summary>
        /// Writes the shallow node.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="writer">The writer.</param>
        /// <exception cref="System.ArgumentNullException">
        /// reader
        /// or
        /// writer
        /// </exception>
        /// <remarks>This is a direct COPY OF CODE from Mark Fussells Weblog
        /// http://blogs.msdn.com/mfussell/archive/2005/02/12/371546.aspx.</remarks>
        public static void WriteShallowNode(this XmlReader reader, XmlWriter writer)
        {

            if (reader == null) throw new ArgumentNullException("reader");
            if (writer == null) throw new ArgumentNullException("writer");


            switch (reader.NodeType)
            {

                case XmlNodeType.Element:

                    writer.WriteStartElement(reader.Prefix, reader.LocalName, reader.NamespaceURI);
                    writer.WriteAttributes(reader, true);
                    if (reader.IsEmptyElement)
                        writer.WriteEndElement();

                    break;

                case XmlNodeType.Text:
                    writer.WriteString(reader.Value);
                    break;

                case XmlNodeType.Whitespace:
                case XmlNodeType.SignificantWhitespace:
                    writer.WriteWhitespace(reader.Value);

                    break;

                case XmlNodeType.CDATA:

                    writer.WriteCData(reader.Value);

                    break;

                case XmlNodeType.EntityReference:

                    writer.WriteEntityRef(reader.LocalName);

                    break;

                case XmlNodeType.XmlDeclaration:

                case XmlNodeType.ProcessingInstruction:

                    writer.WriteProcessingInstruction(reader.LocalName, reader.Value);

                    break;

                case XmlNodeType.DocumentType:

                    writer.WriteDocType(reader.LocalName, reader.GetAttribute("PUBLIC"), reader.GetAttribute("SYSTEM"),
                                        reader.Value);

                    break;

                case XmlNodeType.Comment:

                    writer.WriteComment(reader.Value);

                    break;

                case XmlNodeType.EndElement:

                    writer.WriteFullEndElement();

                    break;

            }
        }

        /// <summary>
        /// Reads to next element.
        /// </summary>
        /// <param name="xr">The xr.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise</returns>
        /// <exception cref="System.ArgumentNullException">xr</exception>
        public static bool ReadToNextElement(this XmlReader xr)
        {
            if (xr == null) throw new ArgumentNullException("xr");
            while (xr.Read())
                if (xr.NodeType == XmlNodeType.Element)
                    return true; // done

            return false;
        }
     
    }

}