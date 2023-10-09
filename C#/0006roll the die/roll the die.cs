/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0006
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/roll-the-die
/// </summary>
/// 
using System;

public class Player
{
    
    public int RollDie()
    {
        var rand = new Random();
        return rand.Next(1,18);
    }

    public double GenerateSpellStrength()
    {
        var rand = new Random();
        return rand.NextDouble();
        
    }

}
