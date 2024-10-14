using System;


/// <summary>
///public class queue
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>  {


/// <summary>
/// class Node
/// </summary>
    public class Node{
        /// <summary>
        /// value of node
        /// </summary>

        public T? Value;

        /// <summary>
        /// reference to the next node in queue
        /// </summary>
        public Node? Next;

        /// <summary>
        /// initializes values
        /// </summary>
        /// <param name="value"></param>
        public Node(T value){
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// head node
    /// </summary>
    protected Node? head;
    /// <summary>
    /// tail node
    /// </summary>
    protected Node? tail;
    // counts the number of nodes
    int count;

/// <summary>
/// queue method
/// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }


/// <summary>
/// enqueue method
/// </summary>
/// <param name="value"></param>
    public void Enqueue(T? value){

        Node newNode = new Node(value!);
    
        if(head == null){
            head = newNode;
            tail = newNode;
        }else{
            tail!.Next = newNode;
            tail = newNode;
        }
         count++;
    }

    
    

/// <summary>
/// checktype method
/// </summary>

    public Type CheckType(){
        return typeof(T);
    }

/// <summary>
/// count method
/// </summary>

    public int Count(){
        return count;
    }
    
}