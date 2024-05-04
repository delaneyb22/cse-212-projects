public static class Priority {
    public static void Test() {
        // Test 1: Enqueue and Dequeue
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 2);
        Console.WriteLine(priorityQueue); // Output: [High (Pri:3), Low (Pri:1), Medium (Pri:2)]
        Console.WriteLine(priorityQueue.Dequeue()); // Output: High
        Console.WriteLine(priorityQueue); // Output: [Low (Pri:1), Medium (Pri:2)]

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2: Multiple items with same high priority
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("High1", 3);
        priorityQueue.Enqueue("High2", 3);
        priorityQueue.Enqueue("Low", 1);
        Console.WriteLine(priorityQueue); // Output: [High1 (Pri:3), High2 (Pri:3), Low (Pri:1)]
        Console.WriteLine(priorityQueue.Dequeue()); // Output: High1
        Console.WriteLine(priorityQueue); // Output: [High2 (Pri:3), Low (Pri:1)]

        // Defect(s) Found: None

        Console.WriteLine("---------");


       // Test 3: Empty queue
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue()); // Output: The queue is empty.

        // Defect(s) Found: None

        Console.WriteLine("---------"); 
    }
}