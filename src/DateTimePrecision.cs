using Ardalis.SmartEnum;

namespace Soenneker.Enums.DateTimePrecision;

/// <summary>
/// An enumerator for describing the level of precision of time
/// </summary>
public sealed class DateTimePrecision : SmartEnum<DateTimePrecision>
{
    public static readonly DateTimePrecision Nanosecond = new(nameof(Nanosecond), 0);
    public static readonly DateTimePrecision Microsecond = new(nameof(Microsecond), 1);
    public static readonly DateTimePrecision Millisecond = new(nameof(Millisecond), 2);
    public static readonly DateTimePrecision Second = new(nameof(Second), 3);
    public static readonly DateTimePrecision Minute = new(nameof(Minute), 4);
    public static readonly DateTimePrecision Hour = new(nameof(Hour), 5);
    public static readonly DateTimePrecision Day = new(nameof(Day), 6);
    public static readonly DateTimePrecision Week = new(nameof(Week), 7);
    public static readonly DateTimePrecision Month = new(nameof(Month), 8);
    public static readonly DateTimePrecision Quarter = new(nameof(Quarter), 9);
    public static readonly DateTimePrecision Year = new(nameof(Year), 10);
    public static readonly DateTimePrecision Decade = new(nameof(Decade), 11);

    private DateTimePrecision(string name, int value) : base(name, value)
    {
    }
}