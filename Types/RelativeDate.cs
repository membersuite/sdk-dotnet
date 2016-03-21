using System;
using System.Xml.Serialization;
using MemberSuite.SDK.Utilities;

namespace MemberSuite.SDK.Types
{
    /// <summary>
    ///     Encapsulates the idea of a "relative" date and time.
    /// </summary>
    /// <remarks>
    ///     Used mostly by search logic. This class can represent, for instance, the concept of
    ///     "5 minutess before right now", or "5 months after the beginning of the fiscal year. Before/After is
    ///     accomplished using signs for the Units property.
    /// </remarks>
    [XmlType(Namespace = "http://membersuite.com/schemas/")]
    [XmlRoot("RelativeDateTime", Namespace = "http://membersuite.com/schemas/",
        IsNullable = false)]
    [Serializable]
    public struct RelativeDateTime
    {
        private RelativeDateTimeReferencePointType _referencePoint;
        private DateTime? _specificDate;
        private int _units;
        private RelativeDateTimeUnitType _unitType;

        public RelativeDateTime(int units, RelativeDateTimeUnitType unitType,
            RelativeDateTimeReferencePointType referencePoint, DateTime? specificDate)
        {
            _units = units;
            _unitType = unitType;
            _referencePoint = referencePoint;
            _specificDate = specificDate;
        }

        public int Units
        {
            get { return _units; }
            set { _units = value; }
        }

        public RelativeDateTimeUnitType UnitType
        {
            get { return _unitType; }
            set { _unitType = value; }
        }

        public RelativeDateTimeReferencePointType ReferencePoint
        {
            get { return _referencePoint; }
            set { _referencePoint = value; }
        }

        /// <summary>
        ///     Gets or sets the specific date, if applicable
        /// </summary>
        /// <value>The specific date.</value>
        public DateTime? SpecificDate
        {
            get { return _specificDate; }
            set { _specificDate = value; }
        }

        public override string ToString()
        {
            switch (ReferencePoint)
            {
                case RelativeDateTimeReferencePointType.SpecificDate:
                    return SpecificDate != null ? SpecificDate.Value.ToShortDateString() : "-";

                case RelativeDateTimeReferencePointType.SpecificDateTime:
                    return SpecificDate != null ? SpecificDate.Value.ToString() : "-";

                case RelativeDateTimeReferencePointType.SpecificTime:
                    return SpecificDate != null ? SpecificDate.Value.ToShortTimeString() : "-";

                default:
                    var friendlyReferencePointName = string.Format("{0}{1}",
                        ReferencePoint !=
                        RelativeDateTimeReferencePointType.RightNow
                            ? "the "
                            : "",
                        Formats.GetFriendlyName(
                            ReferencePoint.ToString()).ToLower());

                    if (Units == 0) // then its just the thing
                        return friendlyReferencePointName;

                    var beforeAfter = Units > 0 ? "after" : "before";

                    //MS-1603
                    //Don't change the units property during ToString() because it changes the definition of the object
                    //For instance - "before" has negative units and this would change it to positive units making it an "after"
                    //Units = Math.Abs(Units);
                    return string.Format("{0} {1} {2} {3}", Math.Abs(Units), UnitType.ToString().ToLower(), beforeAfter,
                        friendlyReferencePointName);
            }
        }
    }

    public enum RelativeDateTimeUnitType
    {
        Minutes = 0,
        Hours = 1,
        Days = 2,
        Weeks = 3,
        Months = 4,
        Years = 5
    }

    public enum RelativeDateTimeReferencePointType
    {
        RightNow = 0,
        BeginningOfTheDay = 1,
        BeginningOfTheWeek = 2,
        BeginningOfTheMonth = 3,
        BeginningOfTheYear = 4,
        BeginningOfTheFiscalYear = 5,
        SpecificDate = 6,
        SpecificDateTime = 7,
        SpecificTime = 8,
        EndOfTheDay = 9,
        EndOfTheWeek = 10,
        EndOfTheMonth = 11,
        EndOfTheYear = 12,
        EndOfTheFiscalYear = 13
    }
}