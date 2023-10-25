using System;

public class Ovissa 
{
    public static void Main( string[] args )
    {
        int count = 0;
        string line;
        if( ( line = Console.ReadLine( ) ) != null )
        {
            for (int i = 0; i < line.Length; i++)
            {
                if( line[ i ] == 'u' )
                {
                    count++;
                }
            }
        }
        Console.WriteLine( count );
    }
}