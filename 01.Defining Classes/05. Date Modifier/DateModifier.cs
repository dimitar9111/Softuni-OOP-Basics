using System;
using System.Globalization;

public class DateModifier
{

    public double CalculateDiff(string firstString,string secondString)
    {
        var days = 0d;
        var firstDate = DateTime.Parse(firstString, CultureInfo.InvariantCulture);
        var secondDate = DateTime.Parse(secondString, CultureInfo.InvariantCulture);
        days = (secondDate - firstDate).TotalDays;
        return Math.Abs(days);
    }
}
