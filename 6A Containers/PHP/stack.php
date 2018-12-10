<?php

    /**********************
     *   OFFICIAL STACK   *
     **********************/


    // Create a stack class
    class Stack {
        // Create a variable that will store the items of the stack
        private $stack;

        // Constructor of the stack class
        public function __construct() {
            // Create a empty array as stack
            $this -> stack = array();
        }

        // The push function add an item to the front of the stack
        public function push( $value ) {
            // Add the item to the beginning of the array 
            array_unshift( $this -> stack, $value );
        }

        // The peek functions returns the first item
        public function peek() {
            // Check whether there are elements in the stack
            if ( count( $this -> stack ) > 0 ) {
                // Return the first item
                return $this -> stack[0];
            }
            
            // There are no items, return 'Leeg'
            return "Leeg";
        }

        // A function that returns the first item and removes it from the stack
        public function pop() {
            // Check whether there are items in the stack
            if ( count( $this -> stack ) > 0 ) {
                // Save the value of the first item in a variable
                $value = $this -> stack[0];
                
                // Use a for loop to loop over all the items of the list
                // We want to move all the items one place forward
                for ( $index = 0; $index < count( $this -> stack ); $index = $index + 1 ) {
                    // Check whether there is another element behind the current one
                    if ( $index + 1 < count($this -> stack) ) {
                        // Place the element of the next location at the current location
                        // This can be seen as moving the element 'forward'
                        $this -> stack[$index] = $this -> stack[$index + 1];
                    }
                }

                // Remove the last element from the stack
                unset( $this -> stack[count( $this -> stack) - 1] );

                // Return the value that we've saved earlier
                return $value;
            }

            // There are no items in the stack, return 'Leeg'
            return "Leeg";
        }
    }

    /************************
     *   UNOFFICIAL STACK   *
     ************************/

    // Create a class that will contain our simple version of the stack
    class SimpleStack {
        // Create a variable that will keep the information from the stack
        private $stack;

        // Costructor of the SimpleStack
        public function __construct() {
            // Create an empty array that for the items of the stack
            $this -> stack = array();
        }

        // The push function add an item to the back of the stack
        public function push( $value ) {
            // Add the item to the back of the stack
            array_push( $this -> stack, $value );
        }

        // The peek functions return the last item of the stack
        public function peek() {
            // Check whether there are items in the stack
            if ( count( $this -> stack ) > 0 ) {
                // Return the last element of the stack
                return $this -> stack[count( $this -> stack ) - 1];
            }
            
            // There are no elements, return 'Leeg'
            return "Leeg";
        }

        // The pop function get the last element of the stack and removes it
        public function pop() {
            // Check whether there are items in the stack
            if ( count( $this -> stack ) > 0 ) {
                // Save the value of the last item
                $value = $this -> stack[count( $this -> stack ) - 1];
                
                // Remove the last item
                unset( $this -> stack[count( $this -> stack ) - 1] );

                // Return the saved value
                return $value;
            }

            // No elements where found, return "Leeg"
            return "Leeg";
        }
    }
