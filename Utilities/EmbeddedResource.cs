using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    ///     Used for retrieveing embedded resources in an assembly
    /// </summary>
    public static class EmbeddedResource
    {
        /// <summary>
        ///     Cache so we don't have to load resources multiple times
        /// </summary>
        private static Dictionary<string, string> _resourceCache;

        static EmbeddedResource()
        {
            _resourceCache = new Dictionary<string, string>();
        }

        /// <summary>
        ///     Loads an embedded resource as XML.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <param name="assembly">The calling assembly (optional)</param>
        /// <returns>An XmlDocument, or null if the resource isn't found</returns>
        public static XmlReader LoadAsXml(string templateName,Assembly assembly=null)
        {
            if (assembly == null)
                assembly = Assembly.GetCallingAssembly();
            // first get the raw string
            var xmlFile = LoadAsString(templateName, assembly);

            // return null
            if (xmlFile == null)
                return null;

            return new XmlTextReader(new StringReader(xmlFile));
        }

        /// <summary>
        ///     Loads an embedded resource as XML.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <returns>An XmlDocument, or null if the resource isn't found</returns>
        public static XDocument LoadAsXmlLinq(string templateName)
        {
            return LoadAsXmlLinq(templateName, Assembly.GetCallingAssembly());
        }

        /// <summary>
        ///     Loads an embedded resource as XML.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <param name="callingAssembly"></param>
        /// <returns>An XmlDocument, or null if the resource isn't found</returns>
        public static XDocument LoadAsXmlLinq(string templateName, Assembly callingAssembly)
        {
            // first get the raw string
            var xmlFile = LoadAsString(templateName, callingAssembly);

            // return null
            if (xmlFile == null)
                return null;

            var xd = XDocument.Parse(xmlFile);

            return xd;
        }

        /// <summary>
        ///     Loads as string.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <returns></returns>
        public static string LoadAsString(string templateName)
        {
            return LoadAsString(templateName, Assembly.GetCallingAssembly());
        }

        /// <summary>
        ///     Loads as string.
        /// </summary>
        /// <param name="templateName">Name of the template.</param>
        /// <param name="callingAssembly">The calling assembly.</param>
        /// <returns></returns>
        public static string LoadAsString(string templateName, Assembly callingAssembly)
        {
            if (templateName == null) throw new ArgumentNullException("templateName");
            string result;

            //  leave this out for now if (_resourceCache.TryGetValue(templateName, out result))
            //    return result;      // cache hit

            // get the stream first
            var stream = callingAssembly.GetManifestResourceStream(templateName);

            // is there a stream?
            if (stream == null)
                return null; // nope - didn't find it

            // get the string
            var sr = new StreamReader(stream);
            result = sr.ReadToEnd();
            // _resourceCache[templateName] = result;  // note this isn't threadsafe, but that's okay
            return result;
        }

        /// <summary>
        ///     Finds all embedded resources in the assembly using the extension
        /// </summary>
        /// <param name="extension">The extension, including the starting period (.)</param>
        /// <returns></returns>
        public static List<string> FindByExtension(string extension)
        {
            return FindByExtension(Assembly.GetExecutingAssembly(), extension);
        }

        /// <summary>
        ///     Finds all embedded resources in the assembly using the extension
        /// </summary>
        /// <param name="extension">The extension, including the starting period (.)</param>
        /// <returns></returns>
        public static List<string> FindByExtension(Assembly assembly, string extension)
        {
            var resources = new List<string>();

            foreach (var name in assembly.GetManifestResourceNames())
                if (name.EndsWith(extension))
                    resources.Add(name);

            return resources;
        }

        public static byte[] LoadAsBytes(string templateName)
        {
            var stream = Assembly.GetCallingAssembly().GetManifestResourceStream(templateName);

            // is there a stream?
            if (stream == null)
                return null; // nothing located

            // get the string
            var bytes = new byte[stream.Length];
            stream.Read(bytes, 0, (int) stream.Length);


            return bytes;
        }
    }
}