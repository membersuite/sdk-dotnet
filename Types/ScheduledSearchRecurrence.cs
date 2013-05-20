using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class ScheduledSearchRecurrence : IMemberSuiteComponent
    {
        [DataMember]
        public ScheduledSearchRecurrenceType Type { get; set; }

        [DataMember]
        public int RecurrenceNumber { get; set; }

        [DataMember]
        public bool ExcludeWeekends { get; set; }

        [DataMember]
        public bool Sunday { get; set; }

        [DataMember]
        public bool Monday { get; set; }

        [DataMember]
        public bool Tuesday { get; set; }

        [DataMember]
        public bool Wednesday { get; set; }

        [DataMember]
        public bool Thursday { get; set; }

        [DataMember]
        public bool Friday { get; set; }

        [DataMember]
        public bool Saturday { get; set; }

        [DataMember]
        public ScheduledSearchRecurrenceEndType EndType { get; set; }

        [DataMember]
        public DateTime? EndDate { get; set; }

        [DataMember]
        public int? NumberOfOccurrences;

        public void Clean()
        {
            // clean recurrence
            switch( Type )
            {
                case ScheduledSearchRecurrenceType.Hourly:
                    if (RecurrenceNumber < 0 || RecurrenceNumber > 59)
                        RecurrenceNumber = 0;
                    break;
            }


            if (EndType == ScheduledSearchRecurrenceEndType.AfterANumberOfOccurrences && NumberOfOccurrences == null)
                EndType = ScheduledSearchRecurrenceEndType.Never;

            if (EndType == ScheduledSearchRecurrenceEndType.OnASpecificDate && EndDate == null)
                EndType = ScheduledSearchRecurrenceEndType.Never;
        }

        public DateTime CalculateNextDate(DateTime refDate)
        {
            switch (Type)
            {
                case ScheduledSearchRecurrenceType.Hourly:
                    
                    if (refDate.Minute >= RecurrenceNumber)  // then it's the NEXT hour
                        refDate = refDate.AddHours(1);

                    var minute = RecurrenceNumber;
                    if (minute > 59)
                        minute = 59;
                    
                    return new DateTime(refDate.Year, refDate.Month, refDate.Day, refDate.Hour , minute, refDate.Second);
                    


                case ScheduledSearchRecurrenceType.Daily:
                    var newDate = refDate.AddDays(RecurrenceNumber);
                    if (ExcludeWeekends)
                    {
                        if (newDate.DayOfWeek == DayOfWeek.Saturday) newDate = newDate.AddDays(2);
                        if (newDate.DayOfWeek == DayOfWeek.Sunday) newDate = newDate.AddDays(1);
                    }

                    return newDate;

                case ScheduledSearchRecurrenceType.Weekly:

                    // let's first see if there's a day this week that works
                    do
                    {
                        if (refDate.DayOfWeek == DayOfWeek.Sunday && Monday)
                            return refDate.AddDays(1); // then, it's the next day
                        if (refDate.DayOfWeek == DayOfWeek.Monday && Tuesday)
                            return refDate.AddDays(1); // then, it's the next day
                        if (refDate.DayOfWeek == DayOfWeek.Tuesday && Wednesday)
                            return refDate.AddDays(1); // then, it's the next day
                        if (refDate.DayOfWeek == DayOfWeek.Wednesday && Thursday)
                            return refDate.AddDays(1); // then, it's the next day
                        if (refDate.DayOfWeek == DayOfWeek.Thursday && Friday)
                            return refDate.AddDays(1); // then, it's the next day
                        if (refDate.DayOfWeek == DayOfWeek.Friday && Saturday)
                            return refDate.AddDays(1); // then, it's the next day

                        refDate = refDate.AddDays(1);   // now, increase the day
                    }
                    while (refDate.DayOfWeek != DayOfWeek.Saturday);

                    var nextWeeksDate = refDate.AddDays(7 * (RecurrenceNumber-1) );   
                    for( int i=0;i<356; i++ )   // put a cap on the recursion
                    {
                        // let's keep incrementing the date until we find it
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Sunday && Sunday ) return nextWeeksDate;
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Monday && Monday ) return nextWeeksDate;
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Tuesday && Tuesday ) return nextWeeksDate;
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Wednesday && Wednesday ) return nextWeeksDate;
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Thursday && Thursday ) return nextWeeksDate;
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Friday && Friday ) return nextWeeksDate;
                        if ( nextWeeksDate.DayOfWeek == DayOfWeek.Saturday && Saturday ) return nextWeeksDate;

                        nextWeeksDate = nextWeeksDate.AddDays( 1 );
                    }
                    throw new ApplicationException("Unable to determine recurrence!");
                
                
                case ScheduledSearchRecurrenceType.Monthly:
                    int month = refDate.Month;

                    if (refDate.Day >= RecurrenceNumber)
                        month++;    // it's next month

                    var day = RecurrenceNumber;
                    if (day > DateTime.DaysInMonth(refDate.Year, month))
                        day = DateTime.DaysInMonth(refDate.Year, month);;

                    return new DateTime(refDate.Year, month, day, refDate.Hour, refDate.Minute, refDate.Second);


                default:
                    throw new ApplicationException("Unable to process type " + Type);
            }
        }

        public override string ToString()
        {
            switch (Type)
            {
                case ScheduledSearchRecurrenceType.Hourly:
                    if (RecurrenceNumber == 0)
                        return "Every hour on the hour";

                    if (RecurrenceNumber == 30)
                        return "Every hour on the half hour";

                    return string.Format("Every hour at {0} minutes past the hour", RecurrenceNumber);

                case ScheduledSearchRecurrenceType.Daily:
                    return string.Format("Every {0} day(s) at the same time",
                        RecurrenceNumber);

                case ScheduledSearchRecurrenceType.Weekly:
                    StringBuilder sb = new StringBuilder(string.Format("Every {0} weeks(s) on: ",
                        RecurrenceNumber));
                    if (Sunday) sb.Append("Sunday, ");
                    if (Monday) sb.Append("Monday, ");
                    if (Tuesday) sb.Append("Tuesday, ");
                    if (Wednesday) sb.Append("Wednesday, ");
                    if (Thursday) sb.Append("Thursday, ");
                    if (Friday) sb.Append("Friday, ");
                    if (Saturday) sb.Append("Saturday, ");

                    return sb.ToString().Trim().TrimEnd(',');

                case ScheduledSearchRecurrenceType.Monthly:
                    return string.Format("Every month on the {0} day of the month",
                        RecurrenceNumber);

                default:
                    throw new NotSupportedException("Cannot process recurrence type " + Type);
            }
        }

        public string GetFriendlyEndString()
        {
            Clean();
            
            switch ( EndType)
            {
                case ScheduledSearchRecurrenceEndType.Never:
                    return "Never - delivery will continue indefinitely";

                case ScheduledSearchRecurrenceEndType.AfterANumberOfOccurrences:
                    return string.Format("After {0:N0} deliveries", NumberOfOccurrences);

                case ScheduledSearchRecurrenceEndType.OnASpecificDate:
                    return string.Format("{0} at  {1}", EndDate.Value.ToLongDateString(),
                         EndDate.Value.ToShortTimeString());

                default:
                    throw new NotSupportedException("unable to process end type " + EndType);
                    
            }

                
        }
    }

    public enum ScheduledSearchRecurrenceType
    {
        Hourly,
        Daily,
        Weekly,
        Monthly
    }

    public enum ScheduledSearchRecurrenceEndType
    {
        Never,
        OnASpecificDate,
        AfterANumberOfOccurrences
    }
}
