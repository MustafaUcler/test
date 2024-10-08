
List<Animal> djur = new List<Animal>
{
    new Animal {Name = "Lejon", Age = 3},
    new Animal {Name = "Katt", Age = 5},
    new Animal {Name = "Hund", Age = 10}
};

List<Animal> ungdjur = djur.Where(a => a.Age > 3).ToList();

foreach (var djuren in ungdjur)
    
{
 Console.WriteLine($"{djuren.Name},{djuren.Age} age ");
}