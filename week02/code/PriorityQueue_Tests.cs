using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: add items with ascendent priority
    // Expected Result: remove items in descendent priority
    // Defect(s) Found: 
    //  1.- the dequeue method does not loop until the last item in the queue
    //  2.- the dequeue method does not removes the item with higher priority before returning the value
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("value1", 1);
        priorityQueue.Enqueue("value2", 2);
        priorityQueue.Enqueue("value3", 3);

        string[] expectedResult = ["value3", "value2", "value1"];
        
        for (int i = 0; i < priorityQueue.Length; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);   
        }
    }

    [TestMethod]
    // Scenario: there are more than one item with the highest priority
    // Expected Result: the item closest to the front of the queue will be removed and its value returned
    // Defect(s) Found: the item closest to the back is removed 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("value2", 2);
        priorityQueue.Enqueue("FirstOut", 3);
        priorityQueue.Enqueue("value1", 1);
        priorityQueue.Enqueue("SecondOut", 3);

        string[] expectedResult = ["FirstOut", "SecondOut", "value2", "value1"];
        
        for (int i = 0; i < priorityQueue.Length; i++)
        {
            var value = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], value);   
        }
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: the queue is empty
    // Expected Result: an error exception shall be thrown
    // Defect(s) Found: none
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
         try
        {
            var value = priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}