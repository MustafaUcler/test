using System.IO.Compression;

Console.WriteLine("Räknare för Svenska bokstäver");

Console.Write("Vänligen skriv något ");

string inmatning = Console.ReadLine();

int mening = 0;
int å = 0;
int ä = 0;
int ö = 0;

foreach (var c in inmatning)
{
    if (c == 'å' | c == 'Å' | c == 'ä' | c == 'Ä'| c == 'ö'| c == 'Ö')
    {
        mening++;
    }
    if (c == 'å'|c== 'Å')
    {
        å++;
    }
    if (c == 'ä'| c== 'Ä')
    {
        ä++;
    }
    if (c == 'ö'| c == 'Ö')
    {
        ö++;
    }

};

if (mening > 0)
{
    Console.WriteLine("Texten är på Svenska");
}

else
{
    Console.WriteLine("Texten är inte på Svenska");
}


Console.WriteLine("Antal Svenska bokstäver " + mening);
Console.WriteLine("Antal å/Å = " + å);
Console.WriteLine("Antal ä/Ä = " + ä);
Console.WriteLine("Antal ö/Ö = " + ö);