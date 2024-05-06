namespace Lista
{
    internal class OrderedList<T> where T : IComparable
    {
        Node<T>? head = null;
        Node<T>? rear = null;

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (this.head == null)
            {
                this.head = this.rear = node;
                return;
            }

            int comparison = this.head.GetData().CompareTo(item);

            if (comparison >= 0)
            {
                node.SetNext(this.head);
                this.head = node;
                return;
            }

            Node<T> current = this.head;

            while (current.Next() != null)
            {
                comparison = current.Next().GetData().CompareTo(item);

                if (comparison >= 0)
                {
                    node.SetNext(current.Next());
                    current.SetNext(node);

                    return;
                }

                current = current.Next();
            }

            this.rear?.SetNext(node);
            this.rear = node;
        }

        public void Display()
        {
            Node<T>? current = this.head;

            while (current != null)
            {
                Console.Write($"{current.GetData()} ");

                current = current.Next();
            }
        }

    }
}
