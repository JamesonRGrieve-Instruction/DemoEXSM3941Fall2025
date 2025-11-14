namespace example;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>(); // Physical Size
        List<int> ages = new List<int>(); // Parallel Array
        string input = "";
        do
        {
            Console.Write("Please Enter a Name or 'exit' to Exit: ");
            input = Console.ReadLine().Trim();
            if (input != "exit")
            {
                names.Add(input);
                Console.Write($"Please Enter the Age of {input}: ");
                ages.Add(int.Parse(Console.ReadLine().Trim()));
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]} is {ages[i]}");
            }
        } while (input != "exit");

    }
}
