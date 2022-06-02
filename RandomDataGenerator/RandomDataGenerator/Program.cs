namespace RandomDataGenerator
{
    class Program
    {
        static int PrintMenu()
        {
            // Print main menu and get user's selection
            Console.WriteLine("Welcome to the Lab 3 Program");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Create a Person object");
            Console.WriteLine("2. Display all of the Person objects created");
            Console.WriteLine("3. Remove a Person object from those created");
            Console.WriteLine("4. Get a random Last Name");
            Console.WriteLine("5. Get a random SSN");
            Console.WriteLine("6. Get a random Phone number");
            Console.WriteLine("0. Exit");
            int choice;
            Int32.TryParse(Console.ReadLine(), out choice);
            return choice;
        }

        static void PrintPeople(List<Person> people)
        {
            for(int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"[{i}] {people[i].FirstName} {people[i].LastName} {people[i].BirthDate} {people[i].SSN.Number} {people[i].Phone.Format()}");
            }
        }
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();
            int choice = PrintMenu();
            while(choice != 0)
            {
                if (choice == 1)
                {
                    Console.WriteLine("How many people would you like to create?");
                    int num;
                    Int32.TryParse(Console.ReadLine(), out num);
                    for (int i = 0; i < num; i++)
                    {
                        Person p = new Person();
                        People.Add(p);
                    }
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < People.Count; i++)
                    {
                        Console.WriteLine(People[i].ToString() + "\n");
                    }
                    if(People.Count == 0)
                    {
                        Person p = new Person();
                        Console.WriteLine(p.ToString());
                    }
                }
                else if (choice == 3)
                {
                    if (People.Count == 0)
                    {
                        Console.WriteLine("There are no people to remove!");
                    }
                    else
                    {
                        PrintPeople(People);
                        Console.WriteLine("Enter the number of the person you want to remove: ");
                        int person;
                        Int32.TryParse(Console.ReadLine(), out person);
                        People.RemoveAt(person);
                    }
                }
                else if (choice == 4)
                {
                    if (People.Count == 0)
                    {
                        Console.WriteLine("There are no people!");
                    }
                    else
                    {
                        Random rand = new Random();
                        Console.WriteLine($"\nRandom Last Name: {People[rand.Next(People.Count)].LastName}\n");
                    }
                }
                else if (choice == 5)
                {
                    if (People.Count == 0)
                    {
                        Console.WriteLine("There are no people!");
                    }
                    else
                    {
                        Random rand = new Random();
                        Console.WriteLine($"\nRandom SSN: {People[rand.Next(People.Count)].SSN.ToString()}\n");
                    }
                }
                else if (choice == 6)
                {
                    if (People.Count == 0)
                    {
                        Console.WriteLine("There are no people!");
                    }
                    else
                    {
                        Console.WriteLine("What separator would you like to use?");
                        char sep;
                        char.TryParse(Console.ReadLine(), out sep);
                        Random rand = new Random();
                        if (sep == '\0')
                        {
                            Console.WriteLine($"\nRandom Phone: {People[rand.Next(People.Count)].Phone.Format()}\n");
                        }
                        else
                        {
                            Console.WriteLine($"\nRandom Phone: {People[rand.Next(People.Count)].Phone.Format(sep)}\n");
                        }
                    }
                }
                choice = PrintMenu();
            }
        }
    }
}