using System;

public class Vidsnuningur
{
    public static void Main( string[] args )
    {
        string? line = Console.ReadLine();
        if( line != null )
        {
            InReverse( line, line.Length - 1 );
        }
    }
    public static void InReverse( string line, int i )
    {
        if( i >= 0 )
        {
            Console.Write( line[ i ] );
            InReverse( line, i - 1 );
        }
    }
}