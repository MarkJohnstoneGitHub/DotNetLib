﻿// https://www.thevbahelp.com/post/calling-c-sharp-code-from-vba-com-interop
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=netframework-4.8.1

using GSystem = global::System;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace DotNetLib.System
{
    [ComVisible(true)]
    [Guid("FC2EAD4C-E155-4A9B-989A-A6D93BAF4738")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IDateTime
    {
        // Constructors
        [Description("Initializes a new instance of the DateTime structure to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.")]
        System.DateTime CreateFromTicks(long ticks, System.DateTimeKind kind = System.DateTimeKind.Unspecified);

        [Description("Initializes a new instance of the DateTime structure to the specified year, month, and day.")]
        System.DateTime CreateFromDate(int year, int month, int day);

        [Description("Initializes a new instance of the DateTime structure to the specified year, month, day, hour, minute, second, and millisecond.")]
        System.DateTime CreateFromDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond = 0);

        [Description("Initializes a new instance of the DateTime structure to the specified year, month, day, hour, minute, second, millisecond, and Coordinated Universal Time (UTC) or local time.")]
        System.DateTime CreateFromDateTimeKind(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind);

        //Fields
        [Description("Represents the largest possible value of DateTime. This field is read-only.")]
        DateTime MaxValue { get; }

        [Description("Represents the smallest possible value of DateTime. This field is read-only.")]
        DateTime MinValue { get; }
        //DateTime UnixEpoch { get; }

        //Properties

        [Description("Gets the date component of this instance.")]
        DateTime Date { get; }

        [Description("Gets the day of the month represented by this instance.")]
        int Day { get; }

        [Description("Gets the day of the week represented by this instance.")]
        DayOfWeek DayOfWeek { get; }

        [Description("Gets the day of the year represented by this instance.")]
        int DayOfYear { get; }

        [Description("Gets the hour component of the date represented by this instance.")]
        int Hour { get; }

        [Description("Gets a value that indicates whether the time represented by this instance is based on local time, Coordinated Universal Time (UTC), or neither.")]
        DateTimeKind Kind { get; }
        //int Microsecond { get; }

        [Description("Gets the milliseconds component of the date represented by this instance.")]
        int Millisecond { get; }

        [Description("Gets the minute component of the date represented by this instance.")]
        int Minute { get; }

        [Description("Gets the month component of the date represented by this instance.")]
        int Month { get; }

        //int Nanosecond { get; }

        [Description("Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time.")]
        DateTime Now { get; }

        [Description("Gets the seconds component of the date represented by this instance.")]
        int Second { get; }

        [Description("Gets the number of ticks that represent the date and time of this instance.")]
        long Ticks { get; }

        [Description("Gets the time of day for this instance.")]
        TimeSpan TimeOfDay { get; }

        [Description("Gets the current date.")]
        DateTime Today { get; }

        [Description("Gets a DateTime object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC).")]
        DateTime UtcNow { get; }

        [Description("Gets the year component of the date represented by this instance.")]
        int Year { get; }

        // Methods

        [Description("Returns a new DateTime that adds the value of the specified TimeSpan to the value of this instance.")]
        DateTime Add(TimeSpan value);

        [Description("Returns a new DateTime that adds the specified number of days to the value of this instance.")]
        DateTime AddDays(double value);

        [Description("Returns a new DateTime that adds the specified number of hours to the value of this instance.")]
        DateTime AddHours(double value);
        //DateTimeTools AddMicoseconds(double value);

        [Description("Returns a new DateTime that adds the specified number of milliseconds to the value of this instance.")]
        DateTime AddMilliseconds(double value);

        [Description("Returns a new DateTime that adds the specified number of minutes to the value of this instance.")]
        DateTime AddMinutes(double value);

        [Description("Returns a new DateTime that adds the specified number of months to the value of this instance.")]
        DateTime AddMonths(int months);

        [Description("Returns a new DateTime that adds the specified number of seconds to the value of this instance.")]
        DateTime AddSeconds(double value);

        [Description("Returns a new DateTime that adds the specified number of ticks to the value of this instance.")]
        DateTime AddTicks(long value);

        [Description("Returns a new DateTime that adds the specified number of years to the value of this instance.")]
        DateTime AddYears(int value);

        [Description("Compares two instances of DateTime and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.")]
        int Compare(DateTime t1, DateTime t2);

        [Description("Compares the value of this instance to a specified DateTime value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified DateTime value.")]
        int CompareTo(DateTime t);

        [Description("Compares the value of this instance to a specified object that contains a specified DateTime value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified DateTime value.")]
        int CompareTo2(object value);

        [Description("Returns the number of days in the specified month and year.")]
        int DaysInMonth(int year, int month);

        [Description("Returns a value indicating whether the value of this instance is equal to the value of the specified DateTime instance.")]
        bool Equals(DateTime value);

        [Description("Returns a value indicating whether this instance is equal to a specified object.")]
        bool Equals2(object value);

        [Description("Returns a value indicating whether two DateTime instances have the same date and time value.")]
        bool Equals3(DateTime t1, DateTime t2);

        [Description("Deserializes a 64-bit binary value and recreates an original serialized DateTime object.")]
        DateTime FromBinary(long dateData);

        [Description("Converts the specified Windows file time to an equivalent local time.")]
        DateTime FromFileTime(long fileTime);

        [Description("Converts the specified Windows file time to an equivalent UTC time.")]
        DateTime FromFileTimeUtc(long fileTime);

        [Description("Returns a DateTime equivalent to the specified OLE Automation Date.")]
        DateTime FromOADate(double d);

        [Description("Converts the value of this instance to all the string representations supported by the standard date and time format specifiers.")]
        string[] GetDateTimeFormats();

        [Description("Returns the hash code for this instance.")]
        int GetHashCode();

        [Description("Indicates whether this instance of DateTime is within the daylight saving time range for the current time zone.")]
        bool IsDaylightSavingTime();

        [Description("Returns an indication whether the specified year is a leap year.")]
        bool IsLeapYear(int year);

        [Description("Converts the string representation of a date and time to its DateTime equivalent by using the conventions of the current culture.")]
        DateTime Parse(string s);

        [Description("Converts the string representation of a date and time to its DateTime equivalent by using the conventions of the current culture.")]
        DateTime Parse2(string s, IFormatProvider provider);

        [Description("Defines the formatting options that customize string parsing for some date and time parsing methods.\r\n\r\nThis enumeration supports a bitwise combination of its member values.")]
        DateTime Parse3(string s, IFormatProvider provider, GSystem.Globalization.DateTimeStyles styles);

        [Description("Converts the specified string representation of a date and time to its DateTime equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.")]
        DateTime ParseExact(string s, string format, IFormatProvider provider);

        [Description("Converts the specified string representation of a date and time to its DateTime equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.")]
        DateTime ParseExact2(string s, string format, IFormatProvider provider, GSystem.Globalization.DateTimeStyles style);

        [Description("Converts the specified string representation of a date and time to its DateTime equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly or an exception is thrown.")]
        DateTime ParseExact3(string s, string[] formats, IFormatProvider provider, GSystem.Globalization.DateTimeStyles style);

        [Description("Creates a new DateTime object that has the same number of ticks as the specified DateTime, but is designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified DateTimeKind value.")]
        DateTime SpecifyKind(DateTime value, DateTimeKind kind);

        [Description("Returns a new DateTime that subtracts the specified duration from the value of this instance.")]
        DateTime Subtract(TimeSpan value);

        [Description("Returns a new TimeSpan that subtracts the specified date and time from the value of this instance.")]
        TimeSpan Subtract2(DateTime value);

        [Description("Serializes the current DateTime object to a 64-bit binary value that subsequently can be used to recreate the DateTime object.")]
        long ToBinary();

        [Description("Converts the value of the current DateTime object to a Windows file time.")]
        long ToFileTime();

        [Description("Converts the value of the current DateTime object to a Windows file time.")] 
        long ToFileTimeUtc();

        [Description("Converts the value of the current DateTime object to local time.")]
        DateTime ToLocalTime();

        [Description("Converts the value of the current DateTime object to its equivalent long date string representation.")]
        string ToLongDateString();

        [Description("Converts the value of the current DateTime object to its equivalent long time string representation.")]
        string ToLongTimeString();


        [Description("Converts the value of this instance to the equivalent OLE Automation date.")]
        double ToOADate();

        [Description("Converts the value of the current DateTime object to its equivalent short date string representation.")] 
        string ToShortDateString();

        [Description("Converts the value of the current DateTime object to its equivalent short time string representation.")]
        string ToShortTimeString();


        [Description("")]
        string ToString(string format = null);

        [Description("")]
        DateTime ToUniversalTime();

        [Description("")]
        bool TryParse(string s, out DateTime result);

        //Operators
        [Description("")]
        DateTime Addition(DateTime d, TimeSpan t);

        [Description("")]
        bool Equality(DateTime d1, DateTime d2);

        [Description("")]
        bool GreaterThan(DateTime t1, DateTime t2);

        [Description("")]
        bool GreaterThanOrEqual(DateTime t1, DateTime t2);

        [Description("")]
        bool Inequality(DateTime t1, DateTime t2);

        [Description("")]
        bool LessThan(DateTime t1, DateTime t2);

        [Description("")]
        bool LessThanOrEqual(DateTime t1, DateTime t2);

        [Description("")]
        TimeSpan Subtraction(DateTime d1, DateTime d2);

        [Description("")]
        DateTime Subtraction2(DateTime d, TimeSpan t);

    }
}