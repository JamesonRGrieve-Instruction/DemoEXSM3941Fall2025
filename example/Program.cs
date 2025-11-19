using System.IO;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>(); // Physical Size
        List<DateOnly> birthdates = new List<DateOnly>(); // Parallel Array
        string input = "";
        do
        {
            Console.Write("Please Enter a Name or 'exit' to Exit: ");
            input = Console.ReadLine().Trim();
            if (input != "exit")
            {
                names.Add(input);
                Console.Write($"Please Enter the Birth Date of {input} (YYYY-MM-DD): ");
                birthdates.Add(DateOnly.Parse(Console.ReadLine().Trim()));
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]} is {Math.Floor((DateOnly.FromDateTime(DateTime.Now).DayNumber - birthdates[i].DayNumber) / 365.25)}");
            }
        } while (input != "exit");
        FileStream stream;
        try
        {
            stream = new FileStream("data.txt", FileMode.CreateNew);
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("name,birthdate");
            }
        }
        catch
        {
            stream = new FileStream("data.txt", FileMode.Append);
        }
        using (StreamWriter writer = new StreamWriter(stream))
        {
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine($"{names[i]},{birthdates[i]}");
            }
        }
    }
}
