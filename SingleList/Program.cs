using System;

namespace SingleList
{
    public class Program
    {
        public static void Main(string[] args)

        {
            CustomLinkedList<int> list1 = new CustomLinkedList<int>();

            list1.AddFirst(7);
            list1.AddFirst(5);
            list1.AddFirst(3);

            //list1.PrintLinkedList(list1);

            list1.AddLast(9);
            list1.AddLast(11);

            //list1.PrintLinkedList(list1);

            Console.WriteLine(list1.Contains(11));

            list1.RemoveLast();

            //list1.PrintLinkedList(list1);

            list1.RemoveFirst();

            //list1.PrintLinkedList(list1);

            // Output:
            // 3-- > 5-- > 7-- > Null
            // 3-- > 5-- > 7-- > 9-- > 11-- > Null
            // True
            // 3-- > 5-- > 7-- > 9-- > Null
            // 5-- > 7-- > 9-- > Null

            list1.Clear();
            CustomLinkedList<int>.PrintLinkedList(list1);

            // Output:
            // Null

        }
    }
}