using System;

namespace SingleList
{
    // Create a Node class to define a node.

    public class CustomNode<T>
    {
        // Constructor specifies node value.
        public CustomNode(T value)
        {
            Value = value;
        }
        // Property: Node Value.
        public T Value { get; set; }

        // Property: NextPointer
        public CustomNode<T> NextPointer { get; set; }
    }

}

