/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0005
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/difference-of-squares
/// </summary>
/// 

using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum =0;
        for (int i=1; i<=max; i++)
        {
            sum +=i;
        }
        int squareOfSum = sum*sum;
        return squareOfSum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum =0;
        for(int i=1; i<=max; i++)
        {
            sum += i*i;
        }
        return sum;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int sumOfSquares = CalculateSumOfSquares(max);
        int squareOfSum = CalculateSquareOfSum(max);

        int differencesOfSquares = squareOfSum-sumOfSquares;

        return differencesOfSquares;
    }
}
