namespace Lista
{
    internal class OrderedIntList
    {
        Node<int>? head = null;
        Node<int>? rear = null;

        public void Add(int item)
        {
            Node<int> node = new Node<int>(item);

            if (this.head == null)
            {
                this.head = this.rear = node;
                return;
            }

            if (this.head.GetData() >= item)
            {
                node.SetNext(this.head);
                this.head = node;
                return;
            }

            Node<int> current = this.head;

            while (current.Next() != null)
            {
                if (current.Next()?.GetData() >= item)
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
            Node<int>? current = this.head;

            while (current != null)
            {
                Console.Write($"{current.GetData()} ");

                current = current.Next();
            }
        }
        
    }
}
