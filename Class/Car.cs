

public class Car
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string model,int year)
    {
        Model = model;
        Year = year;
    }

    public void Cars ()
    {
        Console.WriteLine("Bilar " + Model + Year);
    }


}