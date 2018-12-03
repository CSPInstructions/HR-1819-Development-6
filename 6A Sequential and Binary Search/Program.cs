using System;

namespace searchalgos {
    class Program {
        /*
            Sequential Search
            Search the items one by one until the target has been found
         */
        static int sequentialSearch(int[] numbers, int numberToFind) {
            // Loop over all the items in the array
            for (int index = 0; index < numbers.Length; index = index + 1) {
                // Check whether the current item is the target
                if (numbers[index] == numberToFind) {
                    // Return the index of the number
                    return index;
                }
            }

            // Nothing has been found, return -1
            return -1;
        }

        /*
            Binary Search
            Search the array by splitting it in half each time
            For this to works, the array needs to be ordered from small to large
         */
        static int binarySearch(int[] numbers, int numberToFind) {
            // Define the start index and the end index
            int startIndex = 0;
            int endIndex = numbers.Length - 1;

            // Keep the algoritm going as long as the startIndex is smaller then the endIndex
            while (startIndex <= endIndex) {
                // Get the number in the middle of the current range
                int middleIndex = (startIndex + endIndex) / 2;

                // Check whether the targetnumber is larger then the current center
                if (numberToFind > numbers[middleIndex]) {
                    // Move the startindex to the current center
                    startIndex = middleIndex + 1;
                }

                // Check whether the targetnumber is smaller then the current center
                else if (numberToFind < numbers[middleIndex]) {
                    // Move the endindex to the current center
                    endIndex = middleIndex - 1;
                }

                // The number has been found
                else {
                    // return the current center index
                    return middleIndex;
                }
            }

            // The number hasn't been found, return -1
            return -1;
        }

        static void Main(string[] args) {
            // Create three arrays to check the algorithms 
            int[] numbersCollectionOne   = {1, 3, 5, 7, 9};
            int[] numbersCollectionTwo   = {4, 5, 6, 9};
            int[] numbersCollectionThree = {1, 4, 3, 7, 2};

            // Execute the sequential search
            int seqserAr1 = sequentialSearch(numbersCollectionOne, 5);
            int seqserAr2 = sequentialSearch(numbersCollectionTwo, 5);
            int seqserAr3 = sequentialSearch(numbersCollectionThree, 5);

            // Execute the binary search
            int binser1 = binarySearch(numbersCollectionOne, 5);
            int binser2 = binarySearch(numbersCollectionTwo, 9);

            // Print the results of both algorithms
            Console.WriteLine(seqserAr1 + " " + seqserAr2 + " " + seqserAr3);
            Console.WriteLine(binser1 + " " + binser2);
        }
    }
}
