public class Tree
{
    public string Name { get; set; }
    public int Antal { get; set; }

    public Tree(string name, int antal)
    {
        Name = name;
        Antal = antal;
    }

    public void Trees()
    {
        Console.WriteLine("Träd: " + Name + Antal);
    }
}


