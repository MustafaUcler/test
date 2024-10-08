public class Dog
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Dog(string name,int value)
    {
        Name = name;
        Value = value;
    }

    public void Dogs()
    {
        Console.WriteLine("Hundras: " + Name + Value);
    }
}