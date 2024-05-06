using Lista;

Contact c = new Contact("Luis", "1100");

Contact c2 = new Contact("Anna", "1100");

OrderedList<Contact> list = new OrderedList<Contact>();


list.Add(c);

list.Remove(0);

list.Add(c2);
list.Add(c);

Console.WriteLine(list.Count());

list.Display();