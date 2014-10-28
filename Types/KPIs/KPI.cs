using System;
using System.Runtime.Serialization;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Types.KPIs
{
    [Serializable]
    [DataContract]
    public class KPI
    {
        [DataMember]
        public KPIType Type { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Label { get; set; }

        [DataMember]
        public KPIPeriod CurrentPeriod { get; set; }

        [DataMember]
        public int CurrentPeriodIndex { get; set; }

        [DataMember]
        public double CurrentPeriodValue { get; set; }

        [DataMember]
        public KPIPeriod? PreviousPeriod { get; set; }

        [DataMember]
        public int PreviousPeriodIndex { get; set; }

        [DataMember]
        public double PreviousPeriodValue { get; set; }

        [DataMember]
        public bool Flag { get; set; }

        //public double Change { get; set; }

        public static string GetPeriodString(KPIPeriod period, int index)
        {
            if (period == KPIPeriod.Today || period == KPIPeriod.Current)
                return period.ToString();

            string periodName = Formats.GetFriendlyName(period.ToString());

            switch (index)
            {
                case 0:
                    return "This " + periodName;

                case -1:
                    return "Last " + periodName;

                case 1:
                    return "Next " + periodName;

            }

            if (index < 0)
                return string.Format("{0} {1}s ago", index * -1, periodName);

            return string.Format("{0} {1}s from now", index, periodName);

        }

        /// <summary>
        /// Gets the formatted value.
        /// </summary>
        /// <param name="valueToFormat">The value to format.</param>
        /// <returns></returns>
        /// <remarks>Uses the KPI type to come up with a value</remarks>
        public string GetFormattedValue(double valueToFormat)
        {
            switch (Type)
            {
                case KPIType.Integer:
                    return valueToFormat.ToString("N0");

                case KPIType.Currency:
                    return valueToFormat.ToString("C");

                case KPIType.Double:
                    return valueToFormat.ToString("N0");

                case KPIType.Percentage:
                    return valueToFormat.ToString("P");
            }

            // just do the default
            return valueToFormat.ToString();
        }
    }
}
