public class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            ShowMenu();
            var choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    AddPerson();
                    break;
                case "2":
                    ShowAllPersons();
                    break;
                case "3":
                    UpdatePerson();
                    break;
                case "4":
                    DeletePerson();
                    break;
                case "5":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen!");
                    break;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("\nVälj nedan alternativ:");
        Console.WriteLine("1. Lägg till en person");
        Console.WriteLine("2. Se alla personer");
        Console.WriteLine("3. Uppdatera person");
        Console.WriteLine("4. Radera en person");
        Console.WriteLine("5. Avsluta");
    }

    static void AddPerson()
    {
        using (var context = new PersonDbContext())
        {
            Console.Write("Ange namn: ");
            var name = Console.ReadLine();
            Console.Write("Ange ålder: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                var newPerson = new Person { Name = name, Age = age };
                context.Persons.Add(newPerson);
                context.SaveChanges();
                Console.WriteLine("Person tillagd.");
            }
            else
            {
                Console.WriteLine("Ogiltig ålder. Försök igen.");
            }
        }
    }

    static void ShowAllPersons()
    {
        using (var context = new PersonDbContext())
        {
            var persons = context.Persons.ToList();
            Console.WriteLine("Personer i databasen:");
            foreach (var p in persons)
            {
                Console.WriteLine($"Id: {p.Id}, Namn: {p.Name}, Ålder: {p.Age}");
            }
        }
    }

    static void UpdatePerson()
    {
        ShowAllPersons();
        Console.Write("Ange ID för personen som ska uppdateras: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            using (var context = new PersonDbContext())
            {
                var personToUpdate = context.Persons.Find(id);
                if (personToUpdate != null)
                {
                    Console.Write("Ange nytt namn (lämna tomt för att behålla nuvarande): ");
                    var newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        personToUpdate.Name = newName;
                    }

                    Console.Write("Ange ny ålder (lämna tomt för att behålla nuvarande): ");
                    var newAgeInput = Console.ReadLine();
                    if (int.TryParse(newAgeInput, out int newAge))
                    {
                        personToUpdate.Age = newAge;
                    }

                    context.SaveChanges();
                    Console.WriteLine("Personen har uppdaterats.");
                }
                else
                {
                    Console.WriteLine("Ingen person hittades med det angivna ID:t.");
                }
            }
        }
        else
        {
            Console.WriteLine("Ogiltigt ID. Försök igen.");
        }
    }

    static void DeletePerson()
    {
        ShowAllPersons();
        Console.Write("Ange ID för personen som ska raderas: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            using (var context = new PersonDbContext())
            {
                var personToDelete = context.Persons.Find(id);
                if (personToDelete != null)
                {
                    context.Persons.Remove(personToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Personen har raderats.");
                }
                else
                {
                    Console.WriteLine("Ingen person hittades med det angivna ID:t.");
                }
            }
        }
    }
}
