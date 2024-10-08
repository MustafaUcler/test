
List<string> Namn = new List<string>{ "A","B","C","D"};

List<string> nameNew = Namn.Where(a => a != "A" ).ToList();



foreach (var n in nameNew)
{
    Console.WriteLine(n);
}

