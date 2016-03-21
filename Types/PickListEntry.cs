using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Represents acceptable values in a pick-list type field
    /// </summary>
    [Serializable]
    [DataContract]
    public class PickListEntry : IComparable
    {
        /// <summary>
        ///     Whether or not this entry is active or hidden
        /// </summary>
        private bool _isActive;

        public PickListEntry()
        {
            IsActive = true;
        }

        public PickListEntry(string text)
            : this(text, text)
        {
        }

        public PickListEntry(string text, string val) : this()
        {
            Text = text;
            Value = val;
        }

        /// <summary>
        ///     Whether or not this entry is active or hidden
        /// </summary>
        [XmlIgnore]
        [DataMember]
        public bool IsActive
        {
            get
            {
                // we deferred parsing of the string until now for performance reasons
                if (_isActiveString != null) // it was set
                {
                    bool result;
                    if (!bool.TryParse(_isActiveString, out result))
                        _isActive = true;
                    else
                        _isActive = result;
                }

                return _isActive;
            }
            set
            {
                _isActive = value;
                _isActiveString = null;
            }
        }

        /// <summary>
        ///     Value of the picklist item
        /// </summary>
        [XmlAttribute]
        [DataMember]
        public string Value { get; set; }

        /// <summary>
        ///     Label of the picklist item
        /// </summary>
        [XmlAttribute]
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        ///     Whether or not this is the default picklist entry item
        /// </summary>
        [XmlAttribute]
        [DataMember]
        public bool IsDefault { get; set; }

        /// <summary>
        ///     Whether or not to invert the cascading dependency - i.e.,
        ///     the values specified in the cascading dependency are NOT valid for this
        ///     entry
        /// </summary>
        [XmlAttribute]
        [DataMember]
        public bool InvertCascadingDependency { get; set; }

        /// <summary>
        ///     Defines cascading drop downs
        /// </summary>
        [XmlArray("CascadingDependencies")]
        [XmlArrayItem("DependencyCascadingDependency")]
        [DataMember]
        public List<string> CascadingDropDownParentValues { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this custom field came from a lookup table
        /// </summary>
        /// <value><c>true</c> if [was from lookup table]; otherwise, <c>false</c>.</value>
        [DataMember]
        public bool WasFromLookupTable { get; set; }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            return string.Compare(Value, ((PickListEntry) obj).Value);
        }

        #endregion

        public static List<PickListEntry> FromStrings(params string[] stringsToUse)
        {
            if (stringsToUse == null) throw new ArgumentNullException("stringsToUse");
            var entries = new List<PickListEntry>();
            foreach (var s in stringsToUse)
                entries.Add(new PickListEntry(s));

            return entries;
        }

        /// <summary>
        ///     Creates the specified label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <returns></returns>
        public static PickListEntry Create(string label)
        {
            return Create(label, label);
        }

        /// <summary>
        ///     Creates an new picklist entry
        /// </summary>
        /// <param name="entryLabel">The entry label.</param>
        /// <param name="entryValue">Value to create</param>
        /// <returns></returns>
        public static PickListEntry Create(string entryLabel, string entryValue)
        {
            return new PickListEntry {Text = entryLabel, Value = entryValue};
        }

        /// <summary>
        ///     Returns the string repressentation of this object
        /// </summary>
        /// <remarks>
        ///     This method was basically added to aid in debuging so we can see
        ///     e.g. PickListEntry:label = name
        /// </remarks>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}:{1}", GetType().Name, Text, Value);
        }

        public PickListEntry Clone()
        {
            var clone = (PickListEntry) MemberwiseClone();


            return clone;
        }

        public static List<PickListEntry> FromNameValueStringPairs(List<NameValueStringPair> pairs)
        {
            if (pairs == null) throw new ArgumentNullException("pairs");
            var entries = new List<PickListEntry>();

            foreach (var entry in pairs)
                entries.Add(new PickListEntry(entry.Name, entry.Value));

            return entries;
        }

        #region XML Rendering Workarounds

        public bool ShouldRenderIsActive()
        {
            return !IsActive;
        }

        private string _isActiveString;

        [XmlAttribute("IsActive")]
        public string IsActiveString
        {
            get
            {
                if (IsActive) return null; // performance optimization
                return "false";
            }
            set
            {
                // we're going to optimize this, since this gets called ALOT
                // we'll defer parsing of the string until IsActive
                // is called
                _isActiveString = value;
            }
        }

        #endregion
    }
}