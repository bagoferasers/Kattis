using System;
using System.Net.Mime;

class Program
{
    public static int[]? reluctanceIntegers;
    public static void Main( string[] args )
    {
        try
        {
            //Get children in queue
            int n = Convert.ToInt32( value: Console.ReadLine( ) );
            
            //Get reluctance to meet flourtant
            reluctanceIntegers = new int[ n ];
            string? inputReluctance = Console.ReadLine( ) ?? throw new InvalidInputException( message: "Invalid input: inputReluctance == null" );;
            GetReluctanceValues( inputReluctance, n );

            //Find best place for Bjorn
            PlaceBjorn( n );
        }
        catch( InvalidCastException ex )
        {
            Console.WriteLine( value: ex.Message );
            Environment.Exit( exitCode: 0 );
        }
        catch( System.Exception ex )
        {
            Console.WriteLine( value: ex.Message );
            Environment.Exit( exitCode: 0 );
        }
    }


/// <summary>
/// 
/// </summary>
/// <param name="reluctanceIntegers"></param>
    private static void PlaceBjorn( int n )
    {
        int outputNumber = FindPlace( n );
        // Console.WriteLine( outputNumber );
    }



    private static int FindPlace( int n )
    {
        int positionBjorn = -1;
        int i = 0;
        if( reluctanceIntegers == null )
            throw new InvalidInputException( "Invalid input: reluctanceIntegers is null in FindPlace()" );
        // find 0
        for (i = 0; i < n; i++)
        {
            if ( reluctanceIntegers[ i ] == 0 )
                positionBjorn = i;
        }
        //place 0 at front
        while( reluctanceIntegers[ 0 ] != 0 && positionBjorn > 0 )
        {
            int temp = reluctanceIntegers[ positionBjorn - 1 ];
            reluctanceIntegers[ positionBjorn -1 ] = 0;
            reluctanceIntegers[ positionBjorn-- ] = temp;
        }
        //find best total
        int[] totals = new int[ n ];            
        int sumOfNumbers = 0;
        int bestHappiness = 0;

        for ( i = 0; i < n - 1; i++ )
        {
            for ( int j = 0; j < n; j++ )
            {
                sumOfNumbers += reluctanceIntegers[ j ] * j;
            }
            totals[ i ] = sumOfNumbers;
            ( reluctanceIntegers[ i + 1 ], reluctanceIntegers[ i ] ) = (reluctanceIntegers[ i ], reluctanceIntegers[ i + 1 ] );
        }

        for ( i = 0; i < n; i++ )
        {
            Console.WriteLine( totals[ i ] );
        }

        return bestHappiness;
    }


/// <summary>
/// 
/// </summary>
/// <param name="inputReluctance"></param>
/// <param name="n"></param>
/// <returns></returns>
    private static void GetReluctanceValues( string inputReluctance, int n )
    {
        try
        {
            string[] reluctanceValues = inputReluctance.Split( separator: ' ' );
            if( reluctanceValues.Length != n )
                throw new InvalidInputException( message: "Invalid input: reluctanceValues.Length != n" );
            for (int i = 0; i < n; i++)
            {
                if( int.TryParse( reluctanceValues[ i ], result: out int value ) && reluctanceIntegers != null )
                    reluctanceIntegers[ i ] = value;
                else 
                    throw new InvalidInputException( message: "Invalid input: cannot parse reluctanceValues[" + i + "]" );
            }
        }
        catch( InvalidCastException ex )
        {
            Console.WriteLine( value: ex.Message );
            Environment.Exit( exitCode: 0 );
        }
        catch( System.Exception ex )
        {
            Console.WriteLine( value: ex.Message );
            Environment.Exit( exitCode: 0 );
        }
    }
}


/// <summary>
/// 
/// </summary>
class InvalidInputException : Exception 
{
    public InvalidInputException( string message ) : base( message )
    {
    }
}