string input = Console.ReadLine();
double sum = 0;
while(input!="NoMoreMoney")
{
double pay = double.Parse(input);
    if(pay<0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }
    Console.WriteLine($"Increase: {pay:f2}");
    sum += pay;
    input = Console.ReadLine();
}
Console.WriteLine($"Total: {sum:f2}");
