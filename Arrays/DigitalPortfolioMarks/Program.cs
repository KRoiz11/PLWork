// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digital Portfolio Marking Application");
Console.WriteLine("In a previous year (21/22) the digital portfolio is made up of 14 practical labs across two semesters");
Console.WriteLine("There were 8 labs in semester 1 and 6 labs in semester 2.");
Console.WriteLine("Each lab was awarded a mark between 0 and 5 inclusive.");
Console.WriteLine("Each semester the two lowest marks were discounted - so the final mark was out of 50.");

/*int[] semester1marks = new int[8];

for(int i = 0; i < semester1marks.length; i++)
{
    Console.WriteLine("What marks are awarded for the summative" + (i + 1) + "practical?")
    semester1marks[i] = int.Parse(Console.ReadLine);
}

int lowest = 5, secondlowest = 5;

for (int i = 0; i < semester1marks.length; i++);
{
    if (semester1marks[1] < secondlowest)
    {
        if (semester1marks < lowest)
        {
            secondlowest = lowest;
            lowest = semester1marks[1];
        }
        else
        {
            secondlowest = semester1marks[1];
        }
    }
}

for(int i = 0; i < semester1marks.length; i ++)
{
    totalMarks += semester1marks[i];
}

totalMarks = totalMarks - lowest - secondlowest;
Console.WriteLine(totalMarks);*/

int[] semester2marks = new int[6];

for(int i = 0; i < semester2marks.Length; i++)
{
    Console.WriteLine("What marks are awarded for the summative " + (i + 1) + " practical?");
    semester2marks[i] = int.Parse(Console.ReadLine());
}

int lowest = 5, secondlowest = 5;
int totalmarks = 0;

for(int i = 0; i < semester2marks.Length; i++)
{
    if(semester2marks[i] < secondlowest)
    {
        if(semester2marks[i] < lowest)
        {
            secondlowest = lowest;
            lowest = semester2marks[i];
        }
        else
        {
            secondlowest = semester2marks[i];
        }
    }
}

for(int i = 0; i < semester2marks.Length; i++)
{
    totalmarks = semester2marks[i];
}

totalmarks = totalmarks - lowest - secondlowest;
Console.WriteLine(totalmarks);