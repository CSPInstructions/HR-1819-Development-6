// We're importing the required libraries
using PrettyPrinter;
using System;

// We define a namespace to make our code accessible for the outside world 
namespace Sorting_Algoritms {
    // This is the class of our application
    class Program {
        // We create a function insertionSort
        // Insertion sort orders the numbers one by one, in order
        static void insertionSort( int[] list ) {
            // We loop over the items in the array using indexes, we start at one because the first item can't be compared to anything before it
            for ( int justIndex = 1; justIndex < list.Length; justIndex = justIndex + 1 ) {
                // We save the number that we are trying to get into the right position
                int numberBeingSorted = list[justIndex];

                // We define the index of the number before the one we're trying to get to the right position
                // This will be used to compare the numbers before the one we're sorting
                int orderListIndex = justIndex - 1;

                // We enter a loop that runs as long as the number before the one we're sorting is greater then the one we're sorting
                // The loops also quites when we reach the start of the array
                while ( orderListIndex >= 0 && list[orderListIndex] > numberBeingSorted ) {
                    // If the condition is met, we move the number back to make way for the one we're sorting
                    list[orderListIndex + 1] = list[orderListIndex];

                    // We prepare to compare the next number with the one we're sorting
                    orderListIndex = orderListIndex - 1;
                }

                // We place the number after our current comparison number
                // We do this, because of the -1, we're always a step ahead of the right location
                list[orderListIndex + 1] = numberBeingSorted;
            }
        }

        // We create a function called bubbleSort
        // Bubble sort switches the number we want to get into the right position with the one before it until it's in the right position
        static void bubbleSort( int[] list ) {
            // We loop over the items in the array using indexes, we start at one because the first item can't be compared to anything before it
            for ( int indexBeingSorted = 1; indexBeingSorted < list.Length; indexBeingSorted = indexBeingSorted + 1 ) {
                // We loop over all the items before the one we're trying to sort using indexes
                for ( int sortedIndex = indexBeingSorted - 1; sortedIndex >= 0; sortedIndex = sortedIndex - 1 ) {
                    // We check whether the item before the one that's being sorted is greater then the one we're sorting
                    if ( list[sortedIndex] > list[sortedIndex + 1] ) {
                        // Save the number before the one we're trying to sort
                        int sortedIndexNumber = list[sortedIndex];

                        // Copy our number into the space before it
                        list[sortedIndex] = list[sortedIndex + 1];

                        // Move the number that used to be before the one we're trying to sort into the space that's now behind it.
                        list[sortedIndex + 1] = sortedIndexNumber;
                    }
                }
            }   
        }

        // We create a function named mergeSortProxy, it's only function is to minimize the arguments we have to provide
        static void mergeSortProxy( int[] list ) {
            // We call mergeSort with the required parameters
            mergeSort( list, 0, list.Length - 1 );
        }

        // We create the mergeSort
        // The merge sort breaks an array up into smaller pieces, that are merged individually
        // By merging the smaller arrays back together, we receive a sorted array
        static void mergeSort( int[] list, int startIndex, int endIndex )  {
            // We check whether the startIndex is smaller then the endIndex
            if ( startIndex < endIndex )  {
                // We figure out the center of the given array
                int centerIndex = ( startIndex + endIndex ) / 2;
                
                // We split the array, starting with the left half
                mergeSort( list, startIndex, centerIndex );

                // We continue splitting the array, now the right half
                mergeSort( list, centerIndex + 1, endIndex );

                // We merge the array back together
                merge( list, startIndex, centerIndex, endIndex );
            }
        }

        // We create a function called merge
        // Merge combines two arrays and sorts them while doing so
        static void merge( int[] list, int startIndex, int centerIndex, int endIndex ) {
            // We calculate the sizes of the left and the right array
            int sizeLeftArray       = centerIndex - startIndex + 1;
            int sizeRightArray      = endIndex - centerIndex;

            // We define the starting indexes of the left and right array
            int indexLeftArray      = 0;
            int indexRightArray     = 0;

            // We define the starting index of the merged array, this equals the startIndex provided
            // If our left array starts at index 2 in our merge array then we need the starting index of the merged array to start at 2
            // If it didn't, we would keep overwrting the first item of the merged array
            int indexMergedArray    = startIndex;

            // We define array with the sizes we determined before
            int[] leftArray     = new int[sizeLeftArray];
            int[] rightArray    = new int[sizeRightArray];

            // We start a loop to fill the left array with items
            for ( indexLeftArray = 0; indexLeftArray < sizeLeftArray; indexLeftArray = indexLeftArray + 1 ) {
                // We assign the current element of the left array with the correspending element of the original array
                leftArray[indexLeftArray] = list[startIndex + indexLeftArray];
            }

            // We start a loop to fill the right array with items
            for ( indexRightArray = 0; indexRightArray < sizeRightArray; indexRightArray = indexRightArray + 1 ) {
                // We assign the current element of the left array with the correspending element of the original array
                // We need to increase the index by one, because the center has to be included
                rightArray[indexRightArray] = list[centerIndex + indexRightArray + 1];
            }

            // We reset the indexes of the array in order to loop over them later
            indexLeftArray = 0;
            indexRightArray = 0;

            // We enter a while loop that's gonna merge the two arrays together
            // The while will compare the first element in the left array with the first element in the right array
            // The smallest will be placed into the merged array
            // The loop stops when either the right or the left array runs out of items
            while ( indexLeftArray < sizeLeftArray && indexRightArray < sizeRightArray ) {
                // Check whether the first item in the left array is smaller the the first item in the right array
                if ( leftArray[indexLeftArray] <= rightArray[indexRightArray] ) {
                    // If it is, place the first item of the left array into the merged array
                    list[indexMergedArray]  = leftArray[indexLeftArray];

                    // Increase the index of the left array to move to the next item
                    indexLeftArray          = indexLeftArray + 1;
                } else {
                    // If it isn't, place the first item of the right array into the merged array
                    list[indexMergedArray]  = rightArray[indexRightArray];

                    // Increase the index of the right array to move to the next item
                    indexRightArray         = indexRightArray + 1;
                }

                // Increase the index of the merged array to move on to the next item
                indexMergedArray = indexMergedArray + 1;
            }

            // One of the array is out of item, which means that the other might still have items in it
            // Check whether the left array still has items, if so, we place all of the leftover items into the merged array
            while ( indexLeftArray < sizeLeftArray ) {
                // Add the item to the merged array
                list[indexMergedArray]  = leftArray[indexLeftArray];

                // Increase the index of both the left array and the merged array
                indexLeftArray          = indexLeftArray + 1;
                indexMergedArray        = indexMergedArray + 1;
            }

            // Check whether the right array still has items, if so, we place all of the leftover items into the merged array
            while ( indexRightArray < sizeRightArray ) {
                // Add the item to the merged array
                list[indexMergedArray]  = rightArray[indexRightArray];

                // Increase the index of both the right array and the merged array
                indexRightArray         = indexRightArray + 1;
                indexMergedArray        = indexMergedArray + 1;
            }
        }

        static void Main( string[] args )
        {
            // Create example arrays for all the sort functions
            int[] numbersForInsertionSort = new int[] { 53, 46, 25, 78, 98 };
            int[] numbersForBubbleSort = new int[] { 96, 23, 21, 45, 11 };
            int[] numbersForMergeSort = new int[] { 24, 67, 12, 99, 44 };

            // Use the PrettyPrinter to print the content of the arrays before sorting them
            Printer.printArrayWithIndexesAndValues( numbersForInsertionSort );
            Printer.printArrayWithIndexesAndValues( numbersForBubbleSort );
            Printer.printArrayWithIndexesAndValues( numbersForMergeSort );

            // Execute the sorting algorithms
            insertionSort( numbersForInsertionSort );
            bubbleSort( numbersForBubbleSort );
            mergeSortProxy( numbersForMergeSort );

            // Use the PrettyPrinter to print the content of the arrays after sorting them
            Printer.printArrayWithIndexesAndValues( numbersForInsertionSort );
            Printer.printArrayWithIndexesAndValues( numbersForBubbleSort );
            Printer.printArrayWithIndexesAndValues( numbersForMergeSort );
        }
    }
}