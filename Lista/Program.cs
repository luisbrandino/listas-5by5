using Lista;

Contact c = new Contact("Luis", "1100");

Contact c2 = new Contact("Anna", "1100");

OrderedList<Contact> list = new OrderedList<Contact>();

list.Add(c);

list.Add(c2);

list.Add(new Contact("Bernardo", "1001"));
list.Add(new Contact("Malva", "101"));
list.Add(new Contact("Gabriel", "101"));
list.Add(new Contact("Zebra", "101"));
list.Add(new Contact("Carlos", "101"));
list.Add(new Contact("Darios", "101"));

list.Display();