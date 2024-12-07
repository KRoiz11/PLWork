// See https://aka.ms/new-console-template for more information

int GetNumberInRange(string pPrompt, int pMin, int pMax)
{
    int result = int.MaxValue;
    do
    {
        string input;
 
        Console.WriteLine(pPrompt);
        Console.WriteLine($"Please enter a number between {pMin} and {pMax - 1} inclusive.");
 
        input = Console.ReadLine();
        try
        {
            result = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Something went wrong!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number you entered was too large.");
        }
        
        if (result >= pMin && result < pMax)
        {
            return result;
        }
        Console.WriteLine($"{input} is not between {pMin} and {pMax - 1} inclusive.");
    } while (true);
}
 
int number = GetNumberInRange("Please enter a number.", 1, 101);
Console.WriteLine($"You chose {number}");
