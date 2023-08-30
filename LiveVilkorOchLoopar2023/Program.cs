//int age = 36;
//string name = "Niklas";

//if (name == "Niklas")
//{
//    Console.WriteLine("Niklas du är snäll!");
//}
//else if (age > 35)
//{
//        Console.WriteLine("oof!");
//}
//else
//{
//    Console.WriteLine("Vem är du?");
//}

//Console.WriteLine("_____________________");

//int counter = 0;

//while (name == "Niklas")
//{
//    Console.WriteLine(counter);
//    if (counter > 10)
//    {
//        break;
//    }
//    Console.WriteLine("LOL");
//    counter = counter + 1;
//}
//Console.WriteLine("_____________________");
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    if (name != "Niklas")
//    {
//        break;
//    }
//    Console.WriteLine("LOL");
//}

int[] goodNumbers;
goodNumbers = new int[10];

for (int i = goodNumbers.Length - 1; i >= 0; i--)
{
    goodNumbers[i] = 10 - i;
}

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("_____________________");

Array.Sort(goodNumbers);

foreach (int number in goodNumbers)
{
    Console.WriteLine(number);
}

//foreach (int number in goodNumbers)
//{
//    Console.WriteLine(number);
//}

//int index = 0;

//while (index < goodNumbers.Length)
//{
//    index++;
//}

//string name = "Niklas";

//name = name + "!";

//Console.WriteLine(name.Length);

//Console.WriteLine(name[2]);

//for (int i = 0; i < name.Length; i++)
//{
//    Console.WriteLine(name[i]);
//}

