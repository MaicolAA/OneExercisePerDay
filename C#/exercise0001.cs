/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0001
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/lucians-luscious-lasagna
/// </summary>


class Lasagna
{
    public int minutosCocion = 40;
    
    public int ExpectedMinutesInOven(){
        
        return minutosCocion;
    }

    public int RemainingMinutesInOven(int m){
        
        return minutosCocion - m;
        
    }

    public int PreparationTimeInMinutes(int n){
        return n + n;
    }

    public int ElapsedTimeInMinutes(int x, int y){
        return y + x +x;
    }

   
}