// Importing the right namespaces
using System;

// Defining the namespace of our application
namespace Generic_Sort {
    // Creating a class for our program to run in
    class Program {
        // Create a function name GenericInsertionSort
        // We define this with a generic type called myType
        // myType needs to be a class or type that implements the IComparable interface
        // IComparable is an interface that provides functionality of equals and compareTo
        static void GenericInsertionSort<myType>( myType[] list ) where myType : IComparable {
            // We loop over the items in the array using indexes, we start at one because the first item can't be compared to anything before it
            for (int indexBeingSorted = 1; indexBeingSorted < list.Length; indexBeingSorted = indexBeingSorted + 1) {
                // We save the item that we are trying to get into the right position
                myType numberBeingSorted = list[indexBeingSorted];

                // We define the index of the item before the one we're trying to get to the right position
                // This will be used to compare the items before the one we're sorting
                int orderListIndex = indexBeingSorted - 1;

                // We enter a loop that runs as long as the items before the one we're sorting is greater then the one we're sorting
                // The loops also quites when we reach the start of the array
                while ( orderListIndex >= 0 && list[orderListIndex].CompareTo( numberBeingSorted ) > 0 ) {
                    // If the condition is met, we move the item back to make way for the one we're sorting
                    list[orderListIndex + 1] = list[orderListIndex];

                    // We prepare to compare the next item with the one we're sorting
                    orderListIndex = orderListIndex - 1;
                }

                // We place the item after our current comparison item
                // We do this, because of the -1, we're always a step ahead of the right location
                list[orderListIndex + 1] = numberBeingSorted;
            }
        }

        // The main function is where our program starts
        static void Main( string[] args ) {
            // We define a set of integers where x < y
            int x = 5;
            int y = 7;

            // We demonstrate that in a comparison this results in -1
            System.Console.WriteLine(x.CompareTo( y ));

            // We define a set of integers where x == y
            x = 10;
            y = 10;

            // We demonstrate that in a comparison this results in 0
            System.Console.WriteLine(x.CompareTo( y ));

            // We define a set of integers where x > y
            x = 45;
            y = 7;

            // We demonstrate that in a comparison this results in 1
            System.Console.WriteLine(x.CompareTo( y ));
        }
    }
}
