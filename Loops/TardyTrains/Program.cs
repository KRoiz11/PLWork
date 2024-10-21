// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tardy Train Monitoring Application");

int minutesLate;
int totalTrains = -1;
int trainsLate = 0;
int mostLate = 0;

do
{
    totalTrains += 1;
    Console.WriteLine("How many minutes was the train late?");
    minutesLate = int.Parse(Console.ReadLine());
    if (minutesLate > 0)
    {
        trainsLate += 1;
        if(minutesLate > mostLate)
        {
            mostLate = minutesLate;
        }
    }
} while(minutesLate >= 0);

Console.WriteLine(trainsLate + " out of " + totalTrains + " trains were late.");
Console.WriteLine("The latest train was " + mostLate + " minutes late.");