/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0010
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/elons-toys
/// </summary>
/// 
using System;

class RemoteControlCar
{

    private int batteryPercentage=100;
    private int totalDistance=0;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar auto = new RemoteControlCar();
        return auto;
    }

    public string DistanceDisplay()
    {
        return $"Driven {totalDistance} meters";
    }

    public string BatteryDisplay()
    {
         return batteryPercentage == 0 ? "Battery empty" : $"Battery at {batteryPercentage}%";
    }

    public void Drive()
    {
        if(batteryPercentage>0)
        {
            totalDistance +=20;
            batteryPercentage -=1;
        }
        else
        {
            Console.WriteLine("Battery empty");
        }
    }
}
