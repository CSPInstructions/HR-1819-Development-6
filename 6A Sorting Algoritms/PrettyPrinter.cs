// We define a namespace to make our code accessible for the outside world 
using System;

// We define a namespace to make our code accessible for the outside world 
namespace PrettyPrinter {
    // We define a class named printer
    class Printer {
        // We create a function that prints a line of a given length
        private static void printLine( int length ) {
            // We enter a while loop that keeps going as long as length is greater then 0
            while ( length > 0 ) {
                // We print a dash and keep the cursor on the same line
                Console.Write( "-" );

                // We retrect one from the length
                length = length - 1;
            }
            
            // We move the cursor to the next line
            Console.WriteLine();
        }

        // We create a function that will print the indexes and their values in a [index] => [value] pattern
        // The print will be surrounded by two lines
        public static void printArrayWithIndexesAndValues<T>( T[] arrayToPrint ) {
            // We print a line of length 10
            printLine( 10 );

            // We loop over all the items in the list using a for loop
            // A for loop was chosen to be able to get the index of the values
            for ( int itemIndex = 0; itemIndex < arrayToPrint.Length; itemIndex = itemIndex + 1 ) {
                // We print the current index with it's value
                Console.WriteLine(itemIndex + " => " + arrayToPrint[itemIndex].ToString());
            }

            // We print another line of length 10
            printLine( 10 );
        }
    }
}