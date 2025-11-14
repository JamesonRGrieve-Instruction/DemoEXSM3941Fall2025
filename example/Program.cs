using System.Reflection.PortableExecutable;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("How high would you like to play to?: ");
        int maxPlay = int.Parse(Console.ReadLine());
        int target = random.Next(1, maxPlay + 1);
        int guess = -1;
        int guesses = 0;
        do
        {
            guess = GetRangedInput(1, maxPlay);
            guesses++;
            if (guess > target)
            {
                Console.WriteLine("Lower!");
            }
            else if (guess < target)
            {
                Console.WriteLine("Higher!");
            }
        } while (guess != target);
        Console.WriteLine($"Congrats, You Guessed it in {guesses} Guesses!");
    }
    public static bool ValidateRangedInput(int min, int max, int value)
    {
        return (value >= min && value <= max);

    }
    public static int GetRangedInput(int min, int max)
    {
        int input = 0;
        Console.Write($"Enter a value between {min} and {max}: ");
        try
        {
            input = int.Parse(Console.ReadLine());
        }
        catch
        {

        }
        while (!ValidateRangedInput(min, max, input))
        {
            Console.Write($"Sorry, that's not quite right. Enter a value between {min} and {max}: ");
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
        }
        return input;
    }

}