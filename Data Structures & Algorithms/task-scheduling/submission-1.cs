public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        if (n == 0)
            return tasks.Length;

        // Step 1: Build frequency map
        int[] freq = new int[26];
        foreach (char task in tasks)
        {
            freq[task - 'A']++;
        }

        // Step 2: Initialize max-heap (PriorityQueue with negative priority)
        var maxHeap = new PriorityQueue<int, int>();
        foreach (int f in freq)
        {
            if (f > 0)
                maxHeap.Enqueue(f, -f); // negative priority to simulate max-heap
        }

        // Step 3: Cooldown queue: (remainingCount, availableTime)
        var cooldownQueue = new Queue<(int remainingCount, int availableTime)>();

        int time = 0;

        // Step 4: Simulate CPU cycles
        while (maxHeap.Count > 0 || cooldownQueue.Count > 0)
        {
            time++;

            // Execute the most frequent available task
            if (maxHeap.Count > 0)
            {
                int remaining = maxHeap.Dequeue() - 1;

                // If the task still has remaining executions, add it to cooldown
                if (remaining > 0)
                {
                    cooldownQueue.Enqueue((remaining, time + n));
                }
            }

            // Release tasks whose cooldown has expired
            if (cooldownQueue.Count > 0 &&
                cooldownQueue.Peek().availableTime == time)
            {
                var task = cooldownQueue.Dequeue();
                maxHeap.Enqueue(task.remainingCount, -task.remainingCount);
            }
        }

        return time;
    }
}