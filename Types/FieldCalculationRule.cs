using System;
using System.Runtime.Serialization;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class FieldCalculationRule
    {
        public FieldCalculationRule()
        {
            IsActive = true;
            SkipIfTargetFieldIsSet = true;
            RunOnNewRecordsOnly = true;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string TargetField { get; set; }

        [DataMember]
        public int EvaluationOrder { get; set; }

        /// <summary>
        ///     Gets or sets the expression used the set the value of the target field
        /// </summary>
        /// <value>The expression.</value>
        [DataMember]
        public string Expression { get; set; }

        /// <summary>
        ///     Gets or sets the optional criteria used to determine if the expression is true
        /// </summary>
        /// <value>The criteria.</value>
        [DataMember]
        public string Criteria { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether [skip if target field is set].
        /// </summary>
        /// <value>
        ///     <c>true</c> if [skip if target field is set]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool SkipIfTargetFieldIsSet { get; set; }

        [DataMember]
        public bool RunOnNewRecordsOnly { get; set; }

        [DataMember]
        public string Notes { get; set; }
    }
}