class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.Count > 0) {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        } else {
            Console.WriteLine("Stack is empty");
        }
        bool Contains = aStack.Contains(search);
        if (Contains) {
            Console.WriteLine($"Stack contains \"{search}\": True");
        } else {
            Console.WriteLine($"Stack contains \"{search}\": False");
        }
        while (aStack.Contains(search)) {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}