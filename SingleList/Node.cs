using System;

namespace SingleList
{
    // Create a Node class to define a node.

    public class Node<T>
    {
        // Constructor sets initial node value.
        public Node(T value)
        {
            Value = value;
        }

        // public Property: Value of Node.
        public T Value { get; set; }

        // Property: NextPointer
        public Node<T> Next { get; set; }
    }

}

