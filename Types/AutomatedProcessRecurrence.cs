using System;
using System.Runtime.Serialization;
using System.Text;

namespace MemberSuite.SDK.Types
{
    [Serializable]
    [DataContract]
    public class AutomatedProcessRecurrence : IMemberSuiteComponent
    {
        [DataMember] public int? NumberOfOccurrences;

        [DataMember]
        public AutomatedProcessRecurrenceType Type { get; set; }

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
        public AutomatedProcessRecurrenceEndType EndType { get; set; }

        [DataMember]
        public DateTime? EndDate { get; set; }

        [DataMember]
        public bool RecalculateOnSave { get; set; }

        // need to know the timezone
        public string TimeZone { get; set; }

        public void Clean()
        {
            // clean recurrence
            switch (Type)
            {
                case AutomatedProcessRecurrenceType.Hourly:
                    if (RecurrenceNumber < 0 || RecurrenceNumber > 59)
                        RecurrenceNumber = 0;
                    break;
            }


            if (EndType == AutomatedProcessRecurrenceEndType.AfterANumberOfOccurrences && NumberOfOccurrences == null)
                EndType = AutomatedProcessRecurrenceEndType.Never;

            if (EndType == AutomatedProcessRecurrenceEndType.OnASpecificDate && EndDate == null)
                EndType = AutomatedProcessRecurrenceEndType.Never;
        }

        public DateTime? CalculateNextDate(DateTime refDate)
        {
            return CalculateNextDate(refDate, refDate);
        }

        public DateTime? CalculateNextDate(DateTime refDate, DateTime time)
        {
            var nextDate = _calculateNextDateHelper(refDate, time);

            if (nextDate == null)
                return null;

            // MS-5041
            // Since we performed all date/time calculations in user specific time zone, we have to convert date/time back to Utc.
            // Using DateTime.ToUniversalTime() would not work here since conversion will asssume curent system's time zone which migh
            // be different from current uers's time zone. That is why we've been experiencing time deviation for other then
            // Eastern Standard Time time zone.
            nextDate = TimeZoneInfo.ConvertTimeToUtc(nextDate.Value , TimeZoneInfo.FindSystemTimeZoneById(TimeZone));

            if (EndType == AutomatedProcessRecurrenceEndType.OnASpecificDate && EndDate <= nextDate)
                return null;    // we're done, this is over
            return nextDate;
        }

        public DateTime? _calculateNextDateHelper(DateTime refDate, DateTime time)
        {
            if (TimeZone == null)
                TimeZone = TimeZoneInfo.Local.Id;

            // ok, note we have to work in local time
            // otherwise we cause bugs like MS-4564
            // basically all calculations must work in the time zone contemplated by the user. Otherwise, bad things happen;
            // use says every month on the 15th starting 12/15 at 8:00pm, and UTC conversion makes that 12/16 1:00 am and
            // recurrence is screwed up
            refDate = TimeZoneInfo.ConvertTimeFromUtc(refDate, TimeZoneInfo.FindSystemTimeZoneById(TimeZone));
            time = TimeZoneInfo.ConvertTimeFromUtc(time, TimeZoneInfo.FindSystemTimeZoneById(TimeZone));

            switch (Type)
            {
                case AutomatedProcessRecurrenceType.OneTime:
                    return null;

                case AutomatedProcessRecurrenceType.Hourly:

                    if (refDate.Minute >= RecurrenceNumber) // then it's the NEXT hour
                        refDate = refDate.AddHours(1);

                    var minute = RecurrenceNumber;
                    if (minute > 59)
                        minute = 59;

                    return new DateTime(refDate.Year, refDate.Month, refDate.Day, refDate.Hour, minute, refDate.Second);


                case AutomatedProcessRecurrenceType.Daily:
                    var newDate = refDate.AddDays(RecurrenceNumber);
                    if (ExcludeWeekends)
                    {
                        if (newDate.DayOfWeek == DayOfWeek.Saturday) newDate = newDate.AddDays(2);
                        if (newDate.DayOfWeek == DayOfWeek.Sunday) newDate = newDate.AddDays(1);
                    }

                    newDate = new DateTime(newDate.Year, newDate.Month, newDate.Day,
                        time.Hour, time.Minute, 0);
                    return newDate;

                case AutomatedProcessRecurrenceType.Weekly:

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

                        refDate = refDate.AddDays(1); // now, increase the day
                    } while (refDate.DayOfWeek != DayOfWeek.Saturday);

                    var nextWeeksDate = refDate.AddDays(7*(RecurrenceNumber - 1));
                    nextWeeksDate = new DateTime(nextWeeksDate.Year, nextWeeksDate.Month, nextWeeksDate.Day,
                        time.Hour, time.Minute, 0);
                    for (var i = 0; i < 356; i++) // put a cap on the recursion
                    {
                        // let's keep incrementing the date until we find it
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Sunday && Sunday) return nextWeeksDate;
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Monday && Monday) return nextWeeksDate;
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Tuesday && Tuesday) return nextWeeksDate;
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Wednesday && Wednesday) return nextWeeksDate;
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Thursday && Thursday) return nextWeeksDate;
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Friday && Friday) return nextWeeksDate;
                        if (nextWeeksDate.DayOfWeek == DayOfWeek.Saturday && Saturday) return nextWeeksDate;

                        nextWeeksDate = nextWeeksDate.AddDays(1);
                    }
                    throw new ApplicationException("Unable to determine recurrence!");


                case AutomatedProcessRecurrenceType.Monthly:
                    var dtFloating = refDate;

                    // let's look at what the date would be of this month's recurrence number

                    // so, if recurrence is every month on the 15th at 8:00pm, if I ask for the next scheduled date on 8/15 8:00pm, I should
                    // get that exact date. But a second later - I should get the following month
                    //var dtCurrentMonthRecurrenceNumber = new DateTime(refDate.Year, refDate.Month, RecurrenceNumber,
                    //    time.Hour, time.Minute, time.Second,
                    //    time.Millisecond, DateTimeKind.Utc);

                    // MS-6876 Time portion should not matter here. Above logic can lead to scheduling run several times in a loop.
                    // The logic is simple:
                    // If this run accured before recurrence number (day) then specify next run same month at recurence number
                    // if this run accured at or after recurrence number then move to next month
                    var dtCurrentMonthRecurrenceNumber = new DateTime(refDate.Year, refDate.Month, RecurrenceNumber,
                        0, 0, 0, 0, DateTimeKind.Utc);

                    if (refDate >= dtCurrentMonthRecurrenceNumber)
                        dtFloating = dtFloating.AddMonths(1);

                    var day = RecurrenceNumber;

                    // MS-5041
                    //if (day < dtFloating.Day)
                    //    dtFloating = dtFloating.AddMonths(1);   // it's next month

                    return new DateTime(dtFloating.Year, dtFloating.Month, day, dtFloating.Hour, dtFloating.Minute,
                        dtFloating.Second);

                default:
                    throw new ApplicationException("Unable to process type " + Type);
            }
        }

        public override string ToString()
        {
            switch (Type)
            {
                case AutomatedProcessRecurrenceType.OneTime:
                    return "One time on the specified start date";

                case AutomatedProcessRecurrenceType.Hourly:
                    if (RecurrenceNumber == 0)
                        return "Every hour on the hour";

                    if (RecurrenceNumber == 30)
                        return "Every hour on the half hour";

                    return string.Format("Every hour at {0} minutes past the hour", RecurrenceNumber);

                case AutomatedProcessRecurrenceType.Daily:
                    return string.Format("Every {0} day(s) at the same time",
                        RecurrenceNumber);

                case AutomatedProcessRecurrenceType.Weekly:
                    var sb = new StringBuilder(string.Format("Every {0} week(s) on: ",
                        RecurrenceNumber));
                    if (Sunday) sb.Append("Sunday, ");
                    if (Monday) sb.Append("Monday, ");
                    if (Tuesday) sb.Append("Tuesday, ");
                    if (Wednesday) sb.Append("Wednesday, ");
                    if (Thursday) sb.Append("Thursday, ");
                    if (Friday) sb.Append("Friday, ");
                    if (Saturday) sb.Append("Saturday, ");

                    return sb.ToString().Trim().TrimEnd(',');

                case AutomatedProcessRecurrenceType.Monthly:
                    return string.Format("Every month on the {0} day of the month",
                        RecurrenceNumber);

                default:
                    throw new NotSupportedException("Cannot process recurrence type " + Type);
            }
        }

        public string GetFriendlyEndString()
        {
            Clean();

            switch (EndType)
            {
                case AutomatedProcessRecurrenceEndType.Never:
                    return "Never - delivery will continue indefinitely";

                case AutomatedProcessRecurrenceEndType.AfterANumberOfOccurrences:
                    return string.Format("After {0:N0} deliveries", NumberOfOccurrences);

                case AutomatedProcessRecurrenceEndType.OnASpecificDate:
                    return string.Format("{0} at  {1}", EndDate.Value.ToLongDateString(),
                        EndDate.Value.ToShortTimeString());

                default:
                    throw new NotSupportedException("unable to process end type " + EndType);
            }
        }
    }

    public enum AutomatedProcessRecurrenceType
    {
        OneTime,
        Hourly,
        Daily,
        Weekly,
        Monthly
    }

    public enum AutomatedProcessRecurrenceEndType
    {
        Never,
        OnASpecificDate,
        AfterANumberOfOccurrences
    }
}