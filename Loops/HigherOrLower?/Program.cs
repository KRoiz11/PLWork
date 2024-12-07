// See https://aka.ms/new-console-template for more information
Console.WriteLine("Higher Or Lower?");
 
int secretNumber = new Random().Next(1, 101);

string error = "Bad input.";

int score = 0;
int count = 0;

do
{
    do
    {
        Console.WriteLine("Enter test score:");
        string input = Console.Readline()
        if (int.TryParse(input, int out score));
        {     
            if(score < 0 || score > 100)
            {
                Console.WriteLine(error)
            }
            else
            {
                count += 1
            }
        }
    } while (score.GetType() == typeof(int));
    if(count < 5)
    {
        Console.WriteLine(error)
    }
} while (count < 50)
