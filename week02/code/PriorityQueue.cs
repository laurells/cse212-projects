public class PriorityQueue {
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue irregardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority) {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    /// <summary>
    /// Remove and return the item with the highest priority. If there are multiple
    /// items with the same highest priority, returns the one that was enqueued first.
    /// If the queue is empty, prints an error message and returns null.
    /// </summary>
    /// <returns>The value of the dequeued item, or null if the queue is empty.</returns>
    public String Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            Console.WriteLine("The queue is empty.");
            return null;
        }

        // Find the index of the item with the highest priority to remove
        // var highPriorityIndex = 0;
        // for (int index = 1; index < _queue.Count - 1; index++) {
        //     if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
        //         highPriorityIndex = index;
        // }
        var highPriorityIndex = 0;
        for (int i = 1; i < _queue.Count; i++) {
            if (_queue[i].Priority > _queue[highPriorityIndex].Priority ||
                (_queue[i].Priority == _queue[highPriorityIndex].Priority && i < highPriorityIndex)) {
                highPriorityIndex = i;
            }
        }

        // Remove and return the item with the highest priority
        var value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }

    public override string ToString() {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem {
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }

    public override string ToString() {
        return $"{Value} (Pri:{Priority})";
    }
}
