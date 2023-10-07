
/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0003
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/leap
/// </summary>
/// 

using System;

public static class Leap
{

    public static bool IsLeapYear(int year)
    {
        bool isDivisibleBy4 = year % 4 == 0;
        bool isDivisibleBy100 = year % 100 == 0;
        bool isDivisibleBy400 = year % 400 == 0;

        if (isDivisibleBy4 && (!isDivisibleBy100 || isDivisibleBy400))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}