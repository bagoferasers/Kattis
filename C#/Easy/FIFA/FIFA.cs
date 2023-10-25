using System;

public class FIFA
{
    public static void Main( string[] args )
    {
        // Console.WriteLine( "Hello World!");
        int year = 2022;
        int n  = Convert.ToInt32( Console.ReadLine( ) );
        int k = Convert.ToInt32( Console.ReadLine( ) );
        int yearsSince = n / k;
        year += yearsSince;
        Console.WriteLine( year );
    }
}