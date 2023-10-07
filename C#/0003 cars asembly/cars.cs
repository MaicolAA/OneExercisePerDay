
/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0003
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/cars-assemble
/// </summary>
/// 

using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0.00;
        }
        else if (speed > 0 && speed < 5)
        {
            return 1.0;
        }
        else if (speed >= 5 && speed < 9)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        else
        {
            return 0.0; 
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        double productionRate = speed*successRate * 221;
        return productionRate;
    }

    public static double WorkingItemsPerMinute(int speed)
    {
        double pr2 = ProductionRatePerHour(speed);
        double prperminute = Math.Floor(pr2/60.0);
        return prperminute;
    }
}