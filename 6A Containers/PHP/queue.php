<?php
    // Define a class that will serve as que
    class Queue {
        // Create a variable that will store the list of items
        private $queue;

        // Constructor of the queue
        public function __construct() {
            // Create an empty array as start of the queue
            $this -> queue = array();
        }

        // Function that add an item to the back of the queue
        public function enqueue( $value ) {
            // Add the value to the back of the queue
            array_push( $this -> queue, $value );
        }

        // A function that returns the of the first item
        public function peek() {
            // Check whether there are items in the queue
            if ( count( $this -> queue ) > 0 ) {
                // Return the first item
                return $this -> queue[0];
            }
            
            // There are no items, return 'Leeg'
            return "Leeg";
        }

        // A function that returns the first item and removes it from the queue
        public function dequeue() {
            // Check whether there are items in the queue
            if ( count( $this -> queue ) > 0 ) {
                // Save the value of the first item in a variable
                $value = $this -> queue[0];
                
                // Use a for loop to loop over all the items of the list
                // We want to move all the items one place forward
                for ( $index = 0; $index < count( $this -> queue ); $index = $index + 1 ) {
                    // Check whether there is another element behind the current one
                    if ( $index + 1 < count($this -> queue) ) {
                        // Place the element of the next location at the current location
                        // This can be seen as moving the element 'forward'
                        $this -> queue[$index] = $this -> queue[$index + 1];
                    }
                }

                // Remove the last element from the queue
                unset( $this -> queue[count( $this -> queue) - 1] );

                // Return the value that we've saved earlier
                return $value;
            }

            // There are no items in the queue, return 'Leeg'
            return "Leeg";
        }
    }