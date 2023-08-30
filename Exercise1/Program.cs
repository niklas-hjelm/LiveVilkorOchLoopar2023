// See https://aka.ms/new-console-template for more information

//Skriv ett program som frågar efter användarens namn och skriver ut en hälsning på konsolen.
//Om namnet är "David" ska det skriva ut "Hej David!"

//Fråga användaren efter ett namn
Console.WriteLine("Vad heter du?");

//Ta emot ett namn
string name = "";
name = Console.ReadLine();

//Om det inskrivna namnet är "David"
if (name == "David" || name == "Niklas")
{
    // Skriv ut: "Hej David!"
    Console.WriteLine("Hej David!");
}
