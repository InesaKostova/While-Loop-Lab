string username = Console.ReadLine();
string password = Console.ReadLine();

string currentpass =Console.ReadLine();

while(currentpass!=password)
{
    currentpass = Console.ReadLine();
}
Console.WriteLine($"Welcome {username}!");
