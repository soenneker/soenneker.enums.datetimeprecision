using Ardalis.SmartEnum;

namespace Soenneker.Enums.DateTimePrecision;

/// <summary>
/// An enumerator for describing the level of precision of time
/// </summary>
public sealed class DateTimePrecision : SmartEnum<DateTimePrecision>
{
    public static readonly DateTimePrecision Second = new(nameof(Second), 0);
    public static readonly DateTimePrecision Minute = new(nameof(Minute), 1);
    public static readonly DateTimePrecision Hour = new(nameof(Hour), 2);
    public static readonly DateTimePrecision Day = new(nameof(Day), 3);
    public static readonly DateTimePrecision Month = new(nameof(Month), 4);
    public static readonly DateTimePrecision Year = new(nameof(Year), 5);

    private DateTimePrecision(string name, int value) : base(name, value)
    {
    }
}