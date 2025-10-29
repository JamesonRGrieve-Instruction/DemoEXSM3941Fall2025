namespace example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string userName;
        const string GREETING = "Hello, ";
        // Prompt for input without newline.
        do
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine().Trim();
            if (userName.Length == 0)
            {
                Console.WriteLine("It doesn't look like you've given me a name!");
            }
        } while (userName.Length == 0);
        Console.WriteLine($"{GREETING}{userName}!");


    }
}
