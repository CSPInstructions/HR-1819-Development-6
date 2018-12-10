<?php 
    // Create a class for the LinkedList
    class LinkedList {
        // Create a variable that will store the value of the current Node
        private $value;

        // Create a variable that will store the link to the next node
        private $next;

        // Constructor of the LinkedList
        public function __construct( $value, $next ) {
            // Store the information into the variables
            $this -> value = $value;
            $this -> next  = $next;
        }

        // A function that finds the index for a given function
        public function search( $valueToFind ) {
            // Save a copy of the list
            $theList = $this;

            // Create a variable that will keep track of the index
            $currentIndex = 0;
            
            // Create a loop that keeps running as long as the list ain't empty
            while ( $theList != null ) {
                // Check whether the current node contains the value we're looking for
                if ( $theList -> value === $valueToFind ) {
                    // Return the index of the current node
                    return $currentIndex;
                }

                // Move the list to the next element
                $theList = $theList -> next;

                // Increase the index counter
                $currentIndex = $currentIndex + 1;
            }

            // The item hasn't been found, return -1
            return -1;
        }

        // A function that find a value for a given index
        // This function works by counting the index down
        public function findValueOfIndex( $index ) {
            // Save a copy of the list
            $theList = $this;
            
            // Loop over the list as long as there are items and as long as the index is greater than 0
            while ( $theList != null && $index >= 0 ) {
                // Check whether the index has reached 0
                if ( $index == 0 ) {
                    // Return the value of the current item
                    return $theList -> value;
                }

                // Move to the next node of the list
                $theList = $theList -> next;

                // Decrease the index we're looking for
                $index = $index - 1;
            }

            // We didn't find the item, return -1
            return -1;
        }
    }


    // Create a class for the doubly linked list
    class DoublyLinkedList {
        // The doubly linked list has the values of the linked list + previous
        private $value;
        private $next;
        private $previous;

        // Constructor of the doubly linked list
        public function __construct( $value, $next, $previous ) {
            // Store the information into the variables
            $this -> value    = $value;
            $this -> next     = $next;
            $this -> previous = $previous;
        }
    }