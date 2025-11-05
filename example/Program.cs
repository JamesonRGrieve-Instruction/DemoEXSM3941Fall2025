namespace example;

public class Program
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

    static public bool IsPositiveInteger(int input)
    {
        return input > 0;
    }

    public static char CalculateGrade(int score)
    {
        if (score < 0 || score > 100)
            throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");

        if (score >= 90) return 'A';
        if (score >= 80) return 'B';
        if (score >= 70) return 'C';
        if (score >= 60) return 'D';
        return 'F';
    }
}
