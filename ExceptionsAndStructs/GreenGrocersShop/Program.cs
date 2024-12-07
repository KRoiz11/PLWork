// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Green Grocers!");

string filename = "FruitAndVeg.txt";

if (File.Exists(filename))
{
    /*StreamReader reader = new StreamReader(filename);  
    
    int numberOfLines = 0;

    while(!reader.EndOfStream)
    {
        reader.ReadLine();
        numberOfLines++;
    }

    int lineIndex = 0;
    string [] lines = new string [numberOfLines];

    while(!reader.EndOfStream)
    {
        lines[lineIndex] = reader.ReadLine();
        lineIndex++;
    }

    reader.Close();

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
    */

    string [] lines = File.ReadAllLines(filename);

    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }
    

    using (StreamWriter writer = new StreamWriter("Potatoes.txt"))
    {
        foreach(string line in lines)
        {
            if (line.Contains("Potato"))
            {
                char [] exceptions = {':', '[', ']'};
                string [] sections = line.Split(exceptions, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in sections)
                {
                    Console.WriteLine(part);
                }

                string weight = sections [1];
                //string weight = line.Substring(line.LastIndexOf(":") + 1, 4 );
                writer.WriteLine(weight);
            }
        }
    }
}
else
{
    Console.WriteLine($"\"{filename}\" does not exist");
}


