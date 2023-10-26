using System;
/// <summary>
/// Kattis Problem
/// Author: Colby Bailey
/// Date: 26 October, 2023
/// </summary>
public class Ameriskurvinnustadur
{
    /// <summary>
    /// Main takes in an integer and multiplies it by the length of the football
    /// field. It then returns the double, lol. Werk.
    /// </summary>
    public static void Main( )
    {
        double field = 0.09144d;
        int inputNumber = Convert.ToInt32( Console.ReadLine( ) );
        Console.WriteLine( ( field * inputNumber ) );
    }
}