// See https://aka.ms/new-console-template for more information
/*
This pizza shop application asks the user for the value of their food in pounds.
 
If the value of the food is at least £10 then they can get free delivery - otherwise you need to charge an extra £2 for delivery.
 
If the value of the food is more than £14 then they can get free delivery and a free garlic bread.
*/
 
string temp = "";

Console.WriteLine("Welcome to the Pizza Shop Application!");
Console.WriteLine("What was the value of your order?");

int Value = int.Parse(Console.ReadLine());

if (Value >= 10)
{
    if (Value >= 14)
    {
        temp = ". You will get free delivery and free garlic bread!";
    }
    else
    {
        temp = ". You will get free delivery!";
    }
}

Console.WriteLine("The total cost of your order is £" + Value + temp);
