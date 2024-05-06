namespace Lista
{
    internal class List<T>
    {
        Node<T>? head = null;
        Node<T>? rear = null;
        int count = 0;

        public bool Empty() { return head == null; }

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            count++;

            if (this.head == null)
            {
                this.head = this.rear = node;
                return;
            }

            node.SetPrevious(this.rear);
            this.rear?.SetNext(node);
            this.rear = node;
        }

        public void Insert(int index, T item)
        {
            if (index < 0)
                return;

            Node<T> node = new Node<T>(item);

            if (index == 0)
            {
                count++;
                node.SetNext(this.head);
                this.head = node;
                this.rear = this.rear == null ? node : this.rear;
                return;
            }

            if (this.Empty())
                return;

            Node<T>? current = this.head;
            int currentIndex = 1;

            while (current.Next() != null)
            {
                if (currentIndex == index)
                {
                    count++;
                    node.SetNext(current.Next());
                    current.SetNext(node);

                    return;
                }

                currentIndex++;
                current = current.Next();
            }

            count++;
            this.rear?.SetNext(node);
            this.rear = node;
        }

        public void Remove(T item)
        {
            Node<T>? current = this.head;

            while (current != null)
            {
                if (!current.GetData().Equals(item))
                {
                    current = current.Next();
                    continue;
                }

                count--;

                if (current == this.head)
                    this.head = current.Next();

                if (current == this.rear)
                    this.rear = current.Previous();

                current.Previous()?.SetNext(current.Next());
                current.Next()?.SetPrevious(current.Previous());

                break;
            }
        }

        public int Count()
        {
            return count;
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
