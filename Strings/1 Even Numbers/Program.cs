// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Enter a list of numbers seperated by spaces.");
Console.WriteLine("The program will output all the even numbers.");
 
string input = Console.ReadLine();
 
string output = string.Empty;

string [] seperateStrings = input.Split(' ');

foreach (string str in seperateStrings)
{
    int number = int.Parse(str);

    if (number % 2 == 0)
    {
        Console.Write( number + " ");
    }
}


/*
string [] info = { "Name: Felica Walker", "Title: Mz.", 
                   "Age: 47", "Location: Paris", "Gender: F"};
int found = 0;

Console.WriteLine("\nThe initial values in the array are:");
foreach (string s in info)
    Console.WriteLine(s);

Console.WriteLine("\nWe want to retrieve only the key information. That is:");        
foreach (string s in info) 
{
    found = s.IndexOf(": ");
    Console.WriteLine("   {0}", s.Substring(found + 2));
}
*/