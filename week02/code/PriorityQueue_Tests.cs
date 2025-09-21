using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue one item and dequeue it.
    // Expected Result: Returned value is the same, queue becomes empty.
    // Defect(s) Found: Item was not being removed after Dequeue.
       public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities.
    // Expected Result: Always returns highest priority first.
    // Defect(s) Found: Loop skipped last item, so highest-priority at the end was ignored.
    public void TestPriorityQueue_HighestPriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Mid", 5);
        pq.Enqueue("High", 10);

        var result = pq.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority.
    // Expected Result: Dequeue should return them in insertion order (FIFO).
    // Defect(s) Found: Used >= instead of >, so later same-priority items were dequeued first.
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 7);
        pq.Enqueue("Second", 7);
        pq.Enqueue("Third", 7);

        Assert.AreEqual("First", pq.Dequeue());
        Assert.AreEqual("Second", pq.Dequeue());
        Assert.AreEqual("Third", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue.
    // Expected Result: InvalidOperationException with "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();
        var ex = Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}