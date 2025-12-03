using System.IO;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>
        {
            "Liam", "Olivia", "Noah", "Emma", "Oliver",
            "Ava", "Elijah", "Charlotte", "James", "Sophia",
            "William", "Amelia", "Benjamin", "Isabella", "Lucas",
            "Mia", "Henry", "Evelyn", "Theodore", "Harper",
            "Jackson", "Luna", "Samuel", "Aurora", "Sebastian"
        };

        // --- Where ---

        List<string> filteredNames = new List<string>();
        foreach (string name in names)
        {
            if (name[0] == 'S')
            {
                filteredNames.Add(name);
            }
        }
        foreach (string name in filteredNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();


        filteredNames.Clear();
        foreach (string name in names.Where((name) => name[0] == 'S'))
        {
            filteredNames.Add(name);
        }
        foreach (string name in filteredNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();

        filteredNames.Clear();
        filteredNames = names.Where((name) => name[0] == 'S').ToList();
        foreach (string name in filteredNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();

        // --- Select ---
        List<char> lastCharacters = new List<char>();
        foreach (string name in filteredNames)
        {
            lastCharacters.Add(name[name.Length - 1]);
        }

        lastCharacters = filteredNames.Select(name => name[name.Length - 1]).ToList();
        foreach (char letter in lastCharacters)
        {
            Console.Write(letter + " ");
        }
        Console.WriteLine();

        // --- OrderBy ---

        filteredNames = names.Where((name) => name[0] == 'S').OrderBy(name => name).ToList();
        foreach (string name in filteredNames)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();

        // --- Any / All ---

        Console.WriteLine(names.All(name => name.ToLower().Contains('s')));
        Console.WriteLine(filteredNames.All(name => name.ToLower().Contains('s')));


        Console.WriteLine(names.Any(name => name.ToLower().Contains('s')));
        Console.WriteLine(filteredNames.Any(name => name.ToLower().Contains('s')));

        // --- Count ---
        Console.WriteLine(names.Count);
        Console.WriteLine(names.Count((name) => name[0] == 'S'));
    }
}
