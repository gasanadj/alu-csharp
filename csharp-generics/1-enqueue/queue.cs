using System.Collections;

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
    public Type CheckType()
    {
        return typeof(Queue<T>);
    }

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
