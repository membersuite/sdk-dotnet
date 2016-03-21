using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Searching
{
    /// <summary>
    ///     Abstract class representing a logic operation
    /// </summary>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("SearchOperation", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [KnownType(typeof (List<object>))]
    [Serializable]
    [DataContract]
    public abstract class SearchOperation
    {
        /// <summary>
        ///     Represents the parent group
        /// </summary>
        /// <remarks>
        ///     It's CRITICAL that this is NOT serialized, otherwise it will cause exceptions at the WCF level
        ///     as WCF's serializer tries to ready it for the wire
        /// </remarks>
        [NonSerialized] private SearchOperationGroup _parent;

        public SearchOperation()
        {
            ValuesToOperateOn = new List<object>();
            ID = Guid.NewGuid().ToString(); // set a unique ID for the operation
        }

        /// <summary>
        ///     Gets or sets the parent.
        /// </summary>
        /// <value>The parent.</value>
        [XmlIgnore]
        [IgnoreDataMember]
        public SearchOperationGroup Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        [DataMember]
        [XmlAttribute]
        public string ID { get; set; }

        /// <summary>
        ///     Gets or sets the field to seach on
        /// </summary>
        /// <value>The field.</value>
        [DataMember]
        public string FieldName { get; set; }

        /// <summary>
        ///     Gets or sets the values to operate on.
        /// </summary>
        /// <value>The values to operate on.</value>
        [DataMember]
        public List<object> ValuesToOperateOn { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this instance is negative.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is negative; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsNegative
        {
            get { return false; }
        }

        /// <summary>
        ///     Calculates the search hint to be used if this search is to be cached
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///     We only want to include stuff that's relevant to the search strucutre -
        ///     that's why ValuesToOperateOn isn't included!
        /// </remarks>
        public virtual int CalculateSearchHashCode()
        {
            // start with the name of the operation
            var hashCode = GetType().Name.GetHashCode();

            // is there a field? If so, check that
            if (FieldName != null)
                hashCode += FieldName.GetHashCode();


            // It's important that ValuesToOperate is NOT included!

            return hashCode;
        }

        /// <summary>
        ///     Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <remarks>
        ///     We usse this for operations that require navigation the search operation tree, but which
        ///     are too sensitive to be exposed to the User Interface layer - most notably generation of SQL.
        /// </remarks>
        public abstract void Accept(ISearchObjectVisitor visitor);

        public virtual void Clean()
        {
        }

        public virtual void PostSerializationCleanse()
        {
            if (ValuesToOperateOn == null || ValuesToOperateOn.Count == 0)
                return;

            for (var i = 0; i < ValuesToOperateOn.Count; i++)
            {
                var obj = ValuesToOperateOn[i];
                var node = obj as XmlNode[];

                if (node != null && node.Length > 0)
                    ValuesToOperateOn[i] = Xml.Deserialize<object>(node[0]);
            }
        }

        public virtual bool HasCriteriaForField(string fieldName)
        {
            if (string.IsNullOrWhiteSpace(FieldName))
                return string.IsNullOrWhiteSpace(fieldName);

            return FieldName.Equals(fieldName, StringComparison.CurrentCultureIgnoreCase);
        }

        public virtual bool HasCriteriaWithValue(object value)
        {
            if (ValuesToOperateOn == null || ValuesToOperateOn.Count == 0)
                return false;

            foreach (var o in ValuesToOperateOn)
            {
                if (o != null)
                {
                    if (o.Equals(value))
                        return true;
                }
                else
                {
                    if (value == null)
                        return true;
                }
            }

            return false;
        }

        public virtual List<string> GetMergeCriteriaFields()
        {
            var result = new List<string>();
            if (ValuesToOperateOn == null)
                return result;

            foreach (var o in ValuesToOperateOn)
            {
                var s = o as string;
                if (s == null)
                    continue;

                if (s.StartsWith("##") && s.EndsWith("##") &&
                    !result.Contains(s, StringComparer.InvariantCultureIgnoreCase))
                    result.Add(s);
            }

            return result;
        }

        public virtual void ReplaceCriteriaValue(object oldValue, object newValue)
        {
            if (ValuesToOperateOn == null)
                return;

            for (var i = 0; i < ValuesToOperateOn.Count; i++)
            {
                if (ValuesToOperateOn[i] != null)
                {
                    if (ValuesToOperateOn[i].Equals(oldValue))
                        ValuesToOperateOn[i] = newValue;
                }
                else
                {
                    if (oldValue == null)
                        ValuesToOperateOn[i] = newValue;
                }
            }
        }

        #region Parameterization

        /// <summary>
        ///     Gets a value indicating whether this operation can be parameterized
        /// </summary>
        /// <value>
        ///     <c>true</c> if [supports parameterization]; otherwise, <c>false</c>.
        /// </value>
        public virtual bool SupportsParameterization
        {
            get { return false; }
        }

        public virtual int NumberOfParameters
        {
            get { return 1; }
        }


        /// <summary>
        ///     Gets or sets a value indicating whether this operation is enabled for parameterization.
        /// </summary>
        /// <value>
        ///     <c>true</c> if [enable parameterization]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public virtual bool EnableParameterization { get; set; }

        #endregion
    }
}