using System.IO;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>(); // Physical Size
        List<DateOnly> birthdates = new List<DateOnly>(); // Parallel Array
        const string FILENAME = "data.txt", HEADER = "name,birthdate";
        using (StreamReader reader = File.OpenText(FILENAME))
        {
            string line = null;
            do
            {
                line = reader.ReadLine();
                if (line != null & line != HEADER)
                {
                    string[] splitLine = line.Split(',');
                    names.Add(splitLine[0]);
                    birthdates.Add(DateOnly.Parse(splitLine[1]));
                }
            } while (line != null);
        }

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
        // try
        // {
        //     stream = new FileStream(FILENAME, FileMode.CreateNew);
        //     using (StreamWriter writer = new StreamWriter(stream))
        //     {
        //         writer.WriteLine(HEADER);
        //     }
        // }
        // catch
        // {
        //     stream = new FileStream(FILENAME, FileMode.Append);
        // }
        using (StreamWriter writer = new StreamWriter(new FileStream(FILENAME, FileMode.Create)))
        {
            writer.WriteLine(HEADER);
            for (int i = 0; i < names.Count; i++)
            {
                writer.WriteLine($"{names[i]},{birthdates[i]}");
            }
        }
    }
}
