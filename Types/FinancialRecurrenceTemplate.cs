using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Types
{
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("FinancialRecurrenceTemplate", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    [DataContract]
    public class FinancialRecurrenceTemplate : IMemberSuiteComponent
    {
        public FinancialRecurrenceTemplate()
        {
            InitialPercentage = 0;
            BillForNextPeriodAfter = 1;
        }

        [DataMember]
        public RecurrenceType Type { get; set; }

        [DataMember]
        public DateTime? Date { get; set; }

        /// <summary>
        ///     Gets or sets the initial amount (percentage)
        /// </summary>
        /// <value>The initial amount.</value>
        [DataMember]
        public decimal InitialPercentage { get; set; }

        [DataMember]
        public int? PeriodCount { get; set; }

        /// <summary>
        ///     Gets or sets the day of month to recognize revenue
        /// </summary>
        /// <value>The day of month.</value>
        [DataMember]
        public int? DayOfMonth { get; set; }

        /// <summary>
        ///     Gets or sets the custom entries.
        /// </summary>
        /// <value>The custom entries.</value>
        [DataMember]
        public List<RecurrenceEntry> CustomEntries { get; set; }

        [DataMember]
        public short BillForNextPeriodAfter { get; set; }

        [DataMember]
        public bool UseOrderDateAsReference { get; set; }
    }

    [Serializable]
    [DataContract]
    public class RecurrenceEntry
    {
        /// <summary>
        ///     Gets or sets the date.
        /// </summary>
        /// <value>The date.</value>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Gets or sets the percentage.
        /// </summary>
        /// <value>The percentage.</value>
        [DataMember]
        public decimal Percentage { get; set; }
    }

    public enum RecurrenceType
    {
        MonthlyForFixedNumberOfPeriods = 0,
        MonthlyUntilFixedDate = 10,
        QuarterlyForFixedNumberOfPeriods = 20,
        QuarterlyUntilFixedDate = 30,
        YearlyForFixedNumberOfPeriods = 40,
        OnFixedDate = 50,
        MonthlyIndefinitely = 60,
        QuarterlyIndefinitely = 70,
        YearlyIndefinitely = 80
    }
}