namespace Lista
{
    internal class Contact : IComparable
    {
        string name;
        string phone;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public int CompareTo(object? obj)
        {
            Contact? contact = obj as Contact;
            
            return String.Compare(this.name, contact.GetName());
        }

        public string GetName() { return name; }

        public override string ToString()
        {
            return name;
        }
    }
}
