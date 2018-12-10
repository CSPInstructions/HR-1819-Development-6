<?php
    // Make sure that errors are shown
    error_reporting(E_ALL);
    ini_set('display_errors', 1);

    // Include all the necessary files
    include 'linkedlist.php';
    include 'stack.php';
    include 'queue.php';

    /******************
     *  LINKED LISTS  *
     ******************/

    // Create a list with three items
    $list = new LinkedList( 5, new LinkedList( 6, new LinkedList( 15, null ) ) );

    // Search for an item
    echo "LinkedList | Search 6: " . $list -> search( 6 ) . "<br/>";
    echo "LinkedList | Search 9: " . $list -> search( 9 ) . "<br/>";

    // Search for an index
    echo "LinkedList | Index Search 2: " . $list -> findValueOfIndex( 2 ) . "<br/>";
    echo "LinkedList | Index Search 38: " . $list -> findValueOfIndex( 38 ) . "<br/>";

    // Make space
    echo "<br/>";

    /*************
     *   STACK   *
     *************/

    // Create a stack
    $stack = new Stack();

    // Add an item to the stack
    $stack -> push( 5 );

    // Print the top item of the stack
    echo "Stack || First Item: " . $stack -> peek() . "<br/>";

    // Add another item to the stack
    $stack -> push( 10 );

    // Print the top item of the stack
    echo "Stack || Second Item: " . $stack -> peek() . "<br/>";

    // Pop the items
    echo "Stack || First Pop: " . $stack -> pop() . "<br/>";
    echo "Stack || Second Pop: " .$stack -> pop() . "<br/>";
    echo "Stack || Third Pop: " .$stack -> pop() . "<br/>";
    
    echo "<br/>";

    /************************
     *   Unofficial Stack   *
     ************************/

    // Create a stack
    $simpleStack = new SimpleStack();

    // Add an item to the stack
    $simpleStack -> push( 5 );

    // Print the top item of the stack
    echo "Simple Stack || First Item: " . $simpleStack -> peek() . "<br/>";

    // Add another item to the stack
    $simpleStack -> push( 10 );

    // Print the top item of the stack
    echo "Simple Stack || Second Item: " . $simpleStack -> peek() . "<br/>";

    // Pop the items
    echo "Simple Stack || First Pop: " . $simpleStack -> pop() . "<br/>";
    echo "Simple Stack || Second Pop: " .$simpleStack -> pop() . "<br/>";
    echo "Simple Stack || Third Pop: " .$simpleStack -> pop() . "<br/>";
    
    echo "<br/>";

    /*************
     *   Queue   *
     *************/

    // Create a queue
    $queue = new Queue();

    // Place value into the queue
    $queue -> enqueue( 89275 );
    $queue -> enqueue( 980245 );

    // Print the first item in the queue
    echo "Queue || First Item: " . $queue -> peek() . "<br/>";

    // Dequeue all the items
    echo "Queue || First Dequeue: " . $queue -> dequeue() . "<br/>";
    echo "Queue || Second Dequeue: " . $queue -> dequeue() . "<br/>";
    echo "Queue || Third Dequeue: " . $queue -> dequeue() . "<br/>";