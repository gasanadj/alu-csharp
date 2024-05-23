class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        if (aQueue.Count > 0) {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        } else {
            Console.WriteLine("Queue is empty");
        }
        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search)) {
            Console.WriteLine($"Queue contains \"{search}\": True");
        }else{
            Console.WriteLine($"Queue contains \"{search}\": False");
        }

        while(aQueue.Contains(search)) {
            aQueue.Dequeue();
        }
        return aQueue;
    }
}