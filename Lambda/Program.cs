
List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};

List<int> testnumbers = numbers.Where(n => n % 2 == 0).ToList();


Console.WriteLine("Jämna nummer ");

foreach (var number in testnumbers)
{
    Console.WriteLine(number);
}
