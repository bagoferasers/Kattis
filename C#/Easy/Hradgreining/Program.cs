using System;
/// <summary>
/// Kattis Problem
/// Author: Colby Bailey
/// Date: 26 October, 2023
/// </summary>
public class Hradgreining 
{
    /// <summary>
    /// Main function that takes in a dna string of at least three characters
    /// and checks to see if it contains the sequence 'COV.'
    /// </summary>
    /// <param name="args">Not used.</param>
    public static void Main( string[] args )
    {
        string? line = Console.ReadLine( );
        if( line == null )
        {
            Console.WriteLine( "Null!" );
            Environment.Exit( 0 );
        }
        else if( line == "" )
        {
            Console.WriteLine( "Blank!" );
            Environment.Exit( 0 );
        }
        else if( line.Length < 3 )
        {
            Console.WriteLine( "Less than three letters!" );
            Environment.Exit( 0 );
        }
        int i = 0, j = 1, k = 2;

        /// <summary>
        /// Checks for sequence 'COV'
        /// </summary>
        /// <returns>Returns 'Veikur!' if 'COV' sequence is found. Returns
        /// 'Ekki veikur!' if 'COV' sequence is not found.</returns>
        while( k <= ( line.Length - 1 ) )
        {
            if( 
                char.ToUpper( line[ i ] ) == 'C' &&
                char.ToUpper( line[ j ] ) == 'O' &&
                char.ToUpper( line[ k ] ) == 'V' 
            )
            {
                Console.WriteLine( "Veikur!" );
                break;
            }
            else if( k == ( line.Length - 1 ) )
            {
                Console.WriteLine( "Ekki veikur!" );
                break;
            }
            i++; j++; k++;
        }
    }
}