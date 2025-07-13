using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities, then dequeue all of them.
    // Expected Result: Items are dequeued in order of highest priority 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Master", 2);
        priorityQueue.Enqueue("Mind", 3);
        priorityQueue.Enqueue("ABC", 4);

        Assert.AreEqual("ABC", priorityQueue.Dequeue()); //Should be the highest priority
        Assert.AreEqual("Mind", priorityQueue.Dequeue()); // Should be next in priority
        Assert.AreEqual("Master", priorityQueue.Dequeue()); // Lowest priority
    }

    [TestMethod]
    // Scenario: Enqueue two items with the same priority, and dequeue both
    // Expected Result: The first inserted item is dequeued first.
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Master", 9);
        priorityQueue.Enqueue("Mind", 9);

        Assert.AreEqual("Master", priorityQueue.Dequeue());
        Assert.AreEqual("Mind", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException is thrown.
    // Defect(s) Found:
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }


    [TestMethod]
    // Scenario: Enqueue items with negative priorities.
    // Expected Result: Highest (least negative) priority dequeued first.
    // Defect(s) Found:
    public void TestPriorityQueue_NegativePriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Master", -2);
        priorityQueue.Enqueue("Mind", -3);
        priorityQueue.Enqueue("ABC", -4);

        Assert.AreEqual("ABC", priorityQueue.Dequeue()); 
        Assert.AreEqual("Mind", priorityQueue.Dequeue()); 
        Assert.AreEqual("Master", priorityQueue.Dequeue()); 
    }

}