namespace example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string userName;
        const string GREETING = "Hello, ";
        userName = GetInput("Please enter your name: ");
        Console.WriteLine($"{GREETING}{userName}!");
    }
    static string GetInput(string prompt)
    {
        string toReturn;
        do
        {
            Console.Write(prompt);
            toReturn = Console.ReadLine().Trim();
            if (toReturn.Length == 0)
            {
                Console.WriteLine("It doesn't look like you've given me a name!");
            }
        } while (toReturn.Length == 0);
        return toReturn;
    }
}
