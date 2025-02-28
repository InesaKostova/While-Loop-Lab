int n = int.Parse(Console.ReadLine());

int currentNum = 1;
while (currentNum <= n)
{
    Console.WriteLine(currentNum);
    currentNum = currentNum * 2 + 1;
}
