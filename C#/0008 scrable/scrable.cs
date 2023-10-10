/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0008
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/scrabble-score
/// </summary>
/// 

using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int sum = 0;

        input = input.ToUpper();

        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            switch (letter)
            {
                case 'A':
                case 'E':
                case 'R':
                case 'I':
                case 'O':
                case 'U':
                case 'L':
                case 'N':
                case 'S':
                case 'T':
                    sum += 1;
                    break;
                case 'D':
                case 'G':
                    sum += 2;
                    break;
                case 'B':
                case 'C':
                case 'M':
                case 'P':
                    sum += 3;
                    break;
                case 'F':
                case 'H':
                case 'V':
                case 'W':
                case 'Y':
                    sum += 4;
                    break;
                case 'K':
                    sum += 5;
                    break;
                case 'J':
                case 'X':
                    sum += 8;
                    break;
                case 'Q':
                case 'Z':
                    sum += 10;
                    break;
                default:
                    break;
            }
        }
        return sum;
    }
}
