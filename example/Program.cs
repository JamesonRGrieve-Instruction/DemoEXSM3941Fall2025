namespace example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string userName;
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine().Trim();
        Console.WriteLine($"Hello, {userName}!");
    }
}
