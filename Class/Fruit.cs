public class Fruit
{
    public string Name { get; set; }
    public int Antal{ get; set; }

    public Fruit(string name, int antal)
    {
        Name = name;
        Antal = antal;
    }
    public void Fruits()
    {
        Console.WriteLine("Frukt: " + Name + Antal);
    }
}