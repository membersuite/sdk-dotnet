using System;
using System.Xml.Serialization;
using MemberSuite.SDK.Manifests;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Represents command "state" that can be persisted and saved
    /// </summary>
    /// <remarks>
    ///     Note that the value is always a string - not everything can
    ///     be serialized via a WCF service, and making it typeof(object) increases
    ///     the chance a developer somehwere will accidentally dup something in the preferences
    ///     that can't be serialized and spend 2 hours hunting down a bug.
    /// </remarks>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [Serializable]
    public class CommandPreferences : MetadataBase
    {
        private SerializableDictionary<string, string> _preferences;

        public CommandPreferences()
        {
            IsDirty = false;
            _preferences = new SerializableDictionary<string, string>();
        }

        // [Obsolete("Do NOT directly call the preferences dictionary! This is for serialization only.")]
        public SerializableDictionary<string, string> Preferences
        {
            get { return _preferences; }
            set { _preferences = value; }
        }

        [XmlIgnore]
        public bool IsDirty { get; private set; }

        public void SetPreference(string key, string val)
        {
            string existing;
            if (_preferences.TryGetValue(key, out existing))
                if (existing == val)
                    return; // nothing to do

            _preferences[key] = val;
            IsDirty = true;
        }

        public void ClearReference(string key)
        {
            if (!_preferences.ContainsKey(key))
                return; // nothing to do

            _preferences.Remove(key);
            IsDirty = true;
        }

        public string GetPreference(string key)
        {
            string val;

            if (_preferences.TryGetValue(key, out val))
                return val;

            return null;
        }

        /// <summary>
        ///     Marks this instance as being clean, meaning that the preferences have been persisted
        /// </summary>
        public void Clean()
        {
            IsDirty = false;
        }

        public bool TryGetPreference<T>(string key, out T variable)
        {
            string value;

            variable = default(T);

            if (!_preferences.TryGetValue(key, out value))
                return false;

            variable = Xml.Deserialize<T>(value);

            return true;
        }
    }
}