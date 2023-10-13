/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0010
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/darts
/// </summary>
/// 
using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Pow(x*x + y*y, 0.5);

        int score =0;
        
       if(distance <=1){
          score = 10;
       }
       else if(distance <=5){
          score = 5;
       }
       else if(distance<=10){
          score = 1;
       }
    else{
        score =0;
       }

        return score;
    }
}
