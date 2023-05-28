namespace aspmvccore6test1.Models
{
    public class LinkedLists<T>
    {
        public LinkedListNode<T?> Head { get; set; }

        public void Add(T? value)
        {
            var newNode = new LinkedListNode<T?> { Value = value };

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(T value)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        
        public void Print()
        {
            var current = Head;
            //clear global variable
            GVariable.linklistvar.Clear();
            while (current != null)
            {
                Console.WriteLine(current.Value);
                GVariable.linklistvar.Add(Convert.ToString(current.Value));
                current = current.Next;
            }
        }
    }
}
