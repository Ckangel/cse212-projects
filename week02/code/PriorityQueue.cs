using System;
using System.Collections.Generic;

public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Adds a new item to the queue with the specified priority.
    /// </summary>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    /// <summary>
    /// Removes and returns the item with the highest priority.
    /// If multiple items have the same priority, returns the one added first (FIFO).
    /// </summary>
    public string Dequeue()
    {
        if (_queue.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority
        var highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++)
        {
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
            {
                highPriorityIndex = index;
            }
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }

    /// <summary>
    /// Returns the number of items in the queue.
    /// </summary>
    public int Count => _queue.Count;

    /// <summary>
    /// Returns a string representation of the queue for debugging.
    /// </summary>
    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

public class