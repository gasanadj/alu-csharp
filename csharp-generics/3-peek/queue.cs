/// <summary>
/// Generic class Queue
/// </summary>
/// <typeparam name="T"></typeparam>

public class Queue<T>
{
    /// <summary>
    /// Head of the Queue
    /// </summary>
    public Node? head;
    /// <summary>
    /// Tail of the Queue
    /// </summary>
    public Node? tail;
    /// <summary>
    /// Count of the Nodes
    /// </summary>
    public int count;
    /// <summary>
    /// The Node class
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value of a node
        /// </summary>
        public T? value = default;
        /// <summary>
        /// Next pointer of a node
        /// </summary>
        public Node? next = null;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="v"></param>
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
    public void Enqueue(T? value) {
        Node newNode = new Node(value!);
        if(head == null) {
            head = newNode;
            tail = newNode;
        }else {
            tail!.next = newNode;
            tail = newNode;
        }
        count++;
    }
    /// <summary>
    /// A method to remove the first element in the queue
    /// </summary>
    /// <returns></returns>
    public T Dequeue() {
        if (head == null) {
            Console.WriteLine("Queue is empty");
            return default(T)!;
        } else {
            Node current = head;
            head = current.next;
            count--;
            return current!.value!;
        }
    }
    /// <summary>
    /// A method to return the first element in th queue
    /// </summary>
    /// <returns></returns>
    public T Peek() {
        if (head ==  null) {
            Console.WriteLine("Queue is empty");
            return default(T)!;
        } else {
            return head.value!;
        }
    }
    /// <summary>
    /// Method to count all the nodes of a queue
    /// </summary>
    /// <returns></returns>
    public int Count() {
        return count;
    }
}
