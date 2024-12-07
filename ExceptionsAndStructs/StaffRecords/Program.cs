Console.WriteLine("Staff Records Application");
 
string filename = "StaffRecords.csv";

if (File.Exists(filename))
{
    StreamReader reader = new StreamReader(filename);

    string [] lines = File.ReadAllLines(filename);


    StaffRecord [] records = new StaffRecord [lines.Length - 1]; 

    for (int i = 1; i < lines.Length; i++ )
    {
        string [] parts = lines[i].Split(',');
        records[i-1].FirstName = parts[1];
        records[i-1].Surname = parts[0];
        records[i-1].Salary = int.Parse(parts[2]);
    }

    bool sorted;

    do
    {
        sorted = true;

        for (int i = 0; i < records.Length - 1; i++)
        {
            if (records[i].Salary > records[i+1].Salary)
            {
                sorted = false;
                int temp = records[i+1].Salary;
                records[i+1].Salary = records[i].Salary;
                records[i].Salary = temp;
            }
        }

    }while (!sorted);

    for (int i = 0; i < records.Length; i++)
    {
        Console.WriteLine($"{records[i].FirstName} {records[i].Surname} has made ${records[i].Salary} this year!");
    }

    reader.Close();
}
else
{
    Console.WriteLine($"\"{filename}\" does not exist.");
}



struct StaffRecord
{
    public string FirstName;
    public string Surname;
    public int Salary;
}

