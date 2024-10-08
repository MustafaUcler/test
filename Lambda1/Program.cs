

List<Person> personer = new List<Person>
{
    new Person { Name = "Mustafa", Age = 36},
    new Person { Name = "Mustafa1", Age = 26},
    new Person { Name = "Mustafa2", Age = 4}
};

List<Person> olderThan30 = personer.Where(p => p.Age >30).ToList();

foreach (var person in olderThan30)
{
    Console.WriteLine($" {person.Name} ,{person.Age} år");
}