public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities and dequeue them to ensure correct ordering.
        // Expected Result: Items should be dequeued and removed in the order of their priorities.
        Console.WriteLine("Test 1");
        Console.WriteLine("Test Case 1: Enqueue items with different priorities and dequeue them");
        priorityQueue.Enqueue("Task A", 3);
        priorityQueue.Enqueue("Task B", 1);
        priorityQueue.Enqueue("Task C", 2);
        Console.WriteLine("After Enqueue: " + priorityQueue);
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: Task A (priority 3)
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: Task C (priority 2)
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: Task B (priority 1)
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: The queue is empty.

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue items with the same priority and dequeue them to verify FIFO behavior for items with equal priorities.
        // Expected Result: Items should be dequeued in the order they were enqueued. 
        Console.WriteLine("Test 2");
        Console.WriteLine("Test Case 2: Enqueue items with the same priority and dequeue them");
        priorityQueue.Enqueue("Task 1", 2);
        priorityQueue.Enqueue("Task 2", 2);
        priorityQueue.Enqueue("Task 3", 2);
        Console.WriteLine("After Enqueue: " + priorityQueue);
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: Task 1 (priority 2)
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: Task 2 (priority 2)
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: Task 3 (priority 2)
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: The queue is empty.
        Console.WriteLine("---------");

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: Ensure an empty queue returns null
        // Expected result: Returns an error message
        Console.WriteLine("Test 3");
        Console.WriteLine("Test Case 3: Attempt to dequeue from an empty queue");
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Expected: The queue is empty.
        Console.WriteLine("---------");
    }
}
