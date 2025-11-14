namespace example;

public class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[10]; // Physical Size
        int[] ages = new int[10]; // Parallel Array
        int logicalSize = 0;
        string input = "";
        do
        {
            Console.Write("Please Enter a Name or 'exit' to Exit: ");
            input = Console.ReadLine().Trim();
            if (input != "exit")
            {
                names[logicalSize] = input;
                Console.Write($"Please Enter the Age of {input}: ");
                ages[logicalSize] = int.Parse(Console.ReadLine().Trim());
                logicalSize++;
            }
            for (int i = 0; i < logicalSize; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]} is {ages[i]}");
            }
        } while (input != "exit");

    }
}
