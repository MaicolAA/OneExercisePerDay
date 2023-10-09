/// <summary>
/// Serie oneexcersiceperday
/// Numero: 0006
/// Lenguaje:C#
/// Fuente: https://exercism.org/tracks/csharp/exercises/log-levels
/// </summary>
/// 
using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] salida = logLine.Split(':');
        string sal = salida[1].Trim();
        return sal;
        
    }

    public static string LogLevel(string logLine)
    {
            int startIndex = logLine.IndexOf('[') + 1;
            int endIndex = logLine.IndexOf(']');

            string salida = logLine.Substring(startIndex, endIndex - startIndex);

            return salida.ToLower();


        
    }

    public static string Reformat(string logLine)
    {
        string[] salida = logLine.Split(':');
        string sal = salida[1].Trim();

        int startIndex = logLine.IndexOf('[') + 1;
        int endIndex = logLine.IndexOf(']');

        string salida1 = logLine.Substring(startIndex, endIndex - startIndex);
        salida1 = salida1.Trim();
        salida1 = salida1.ToLower();

        string salidas = $"{sal} ({salida1})";
        return salidas;
    }
}
