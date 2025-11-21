using System.IO;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
        const int MAX_GUESSES = 6;
        List<string> words = new List<string>(); // Physical Size
        Random rng = new Random();
        const string FILENAME = "words.txt";
        try
        {
            using (StreamReader reader = File.OpenText(FILENAME))
            {
                string line = null;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        words.Add(line);
                    }
                } while (line != null);
            }
        }
        catch
        {
            Console.WriteLine("No words found! Error!");
        }
        if (words.Count > 0)
        {
            string target = words[rng.Next(words.Count)];
            List<char> guesses = new List<char>();
            bool exit = false;
            do
            {
                Console.Write("Please Choose a Letter: ");
                char guess = char.ToLower(char.Parse(Console.ReadLine().Trim()));
                if (char.IsAsciiLetter(guess))
                {
                    if (!guesses.Contains(guess))
                    {
                        guesses.Add(guess);
                    }
                    else
                    {
                        Console.WriteLine("You already guessed that!");
                    }
                    if (!target.Contains(guess))
                    {
                        Console.WriteLine("Sorry, that isn't in the word.");
                    }
                    bool done = true;
                    foreach (char letter in target)
                    {
                        if (guesses.Contains(letter))
                        {
                            Console.Write(letter + " ");
                        }
                        else
                        {
                            Console.Write("_ ");
                            done = false;
                        }
                    }
                    if (done)
                    {
                        exit = true;
                    }
                }
                else
                {
                    Console.WriteLine("That's not a letter!");
                }

            } while (!exit && guesses.Where(letter => !target.Contains(letter)).Count() < MAX_GUESSES);
            if (exit)
            {
                Console.WriteLine("\nYou win!");
            }
            else
            {
                Console.WriteLine("\nSorry, play again.");
            }
            using (StreamWriter writer = new StreamWriter(new FileStream("record.txt", FileMode.Create)))
            {
                writer.WriteLine($"Word: {target}");
                writer.WriteLine($"Won?: {exit}");
                writer.WriteLine($"Guesses: {guesses.Count}");
                writer.WriteLine($"Played At: {DateTime.Now}");
            }

        }
    }
}
