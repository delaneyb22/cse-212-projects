public static class TakingTurns {
    public class TakingTurnsQueue {
    private class Person {
        public string Name { get; set; }
        public int Turns { get; set; }

        public Person(string name, int turns) {
            Name = name;
            Turns = turns;
        }
    }

    private Queue<Person> queue = new Queue<Person>();

    public void AddPerson(string name, int turns) {
        queue.Enqueue(new Person(name, turns));
    }

    public void GetNextPerson() {
        if (queue.Count == 0) {
            Console.WriteLine("Error: Queue is empty.");
            return;
        }

        var person = queue.Dequeue();
        if (person.Turns > 0) {
            person.Turns--;
            queue.Enqueue(person);
        }
        Console.WriteLine(person.Name);
    }

    public int Length {
        get { return queue.Count; }
    }

    public override string ToString() {
        return string.Join(", ", queue.Select(p => $"{p.Name} ({p.Turns})"));
    }
}
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases
        
        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        
        while (players.Length > 0)
            players.GetNextPerson();
        // summary: Test 1: The output is Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim, which matches the expected result.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.Length > 0)
            players.GetNextPerson();

        // summary: Test 2: The output is Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George, which matches the expected result.


        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 

        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found:
    }
}