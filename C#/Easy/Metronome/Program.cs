using System;

public class Program
{
    public static void Main( string[] args )
    {
        // Console.Write( "Please enter a number:  " );
        string? userInput = Console.ReadLine( );

        if( float.TryParse( userInput, out float floatValue ) )
        {
            float result = floatValue / 4;
            string formattedResult = result.ToString( "0.00" );
            Console.WriteLine( formattedResult );
        }
        else 
        {
            Console.WriteLine( "Invalid input." );
            Environment.Exit( 0 );
        }
    }
}