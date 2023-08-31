int age = 36;
string name = "Niklas";

if (name == "Niklas")
{
    Console.WriteLine("Niklas du är snäll!");
}
else if (age > 35)
{
    Console.WriteLine("oof!");
}
else
{
    Console.WriteLine("Vem är du?");
}

Console.WriteLine("_____________________");

int counter = 0;

while (name == "Niklas")
{
    Console.WriteLine(counter);
    if (counter > 10)
    {
        break;
    }
    Console.WriteLine("LOL");
    counter = counter + 1;
}
Console.WriteLine("_____________________");
Console.WriteLine("_____________________");
Console.WriteLine("_____________________");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (name != "Niklas")
    {
        break;
    }
    Console.WriteLine("LOL");
}

Console.WriteLine("_____________________");
Console.WriteLine("_____________________");
Console.WriteLine("_____________________");

//I koden nedan deklareras och initieras en array av heltal
//
int[] goodNumbers;
goodNumbers = new int[10];

for (int i = goodNumbers.Length - 1; i >= 0; i--)
{
    goodNumbers[i] = goodNumbers.Length - i;
}

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();

Array.Sort(goodNumbers);

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("_____________________");
Console.WriteLine("_____________________");
Console.WriteLine("_____________________");

// Strängar som arrayer av char
string firstName = "Niklas";

firstName = firstName + "!";

Console.WriteLine(firstName.Length);

Console.WriteLine(firstName[2]);

for (int i = 0; i < firstName.Length; i++)
{
    Console.WriteLine(firstName[i]);
}

