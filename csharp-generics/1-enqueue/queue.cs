/// <summary>
/// Generic class Queue
/// </summary>
/// <typeparam name="T"></typeparam>

public class Queue<T>
{
    public Node? head;
    public Node? tail;
    public int count;
    public class Node
    {
        public T? value = default;
        public Node? next = null;
        public Node(T v) {
            value = v;
            next = null;
        }
        
    }
    /// <summary>
    /// Method that returns the type of the Queue
    /// </summary>
    /// <returns></returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Method that adds an item to the queue
    /// </summary>
    /// <param name="value"></param>
    public void Enqueue(T value) {
        Node newNode = new Node(value);
        if(head == null) {
            head = newNode;
            tail = newNode;
        }else {
            tail!.next = newNode;
            tail = newNode;
        }
        count++;
    }

    public int Count() {
        return count;
    }
}
