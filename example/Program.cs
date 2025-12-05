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
        Dictionary<string, string> wordPool = new Dictionary<string, string>
        {
            { "Ephemeral", "Lasting for a very short time." },
            { "Ubiquitous", "Present, appearing, or found everywhere." },
            { "Serendipity", "The occurrence and development of events by chance in a happy or beneficial way." },
            { "Mellifluous", "Sweet or musical; pleasant to hear." },
            { "Quixotic", "Extremely idealistic; unrealistic and impractical." },
            { "Ineffable", "Too great or extreme to be expressed or described in words." },
            { "Nefarious", "Wicked, villainous, or criminal." },
            { "Paradigm", "A typical example or pattern of something; a model." },
            { "Cacophony", "A harsh, discordant mixture of sounds." },
            { "Panacea", "A solution or remedy for all difficulties or diseases." },
            { "Luminous", "Shining or glowing, especially in the dark." },
            { "Resilience", "The capacity to recover quickly from difficulties; toughness." },
            { "Sycophant", "A person who acts obsequiously toward someone important in order to gain advantage." },
            { "Talisman", "An object typically an inscribed ring or stone, that is thought to have magic powers." }
        };

        Random rng = new Random();

        Queue<string> nameQueue = new Queue<string>();
        Queue<Stack<Dictionary<string, string>>> queue = new Queue<Stack<Dictionary<string, string>>>();

        for (int personNum = 1; personNum <= rng.Next(3, 6); personNum++)
        {
            Stack<Dictionary<string, string>> newStack = new Stack<Dictionary<string, string>>();
            for (int dictNum = 1; dictNum <= rng.Next(2, 5); dictNum++)
            {
                Dictionary<string, string> newDictionary = new Dictionary<string, string>();
                for (int wordNum = 1; wordNum <= rng.Next(5, 11); wordNum++)
                {
                    KeyValuePair<string, string> wordToAdd;
                    do
                    {
                        wordToAdd = wordPool.ElementAt(rng.Next(wordPool.Count));
                    } while (newDictionary.ContainsKey(wordToAdd.Key));
                    newDictionary.Add(wordToAdd.Key, wordToAdd.Value);
                }
                newStack.Push(newDictionary);
            }
            queue.Enqueue(newStack);
            nameQueue.Enqueue(names[rng.Next(names.Count)]);
        }

        Console.WriteLine($"A queue of {nameQueue.Count} people form in front of the desk, {string.Join(", ", nameQueue)}.");
        do
        {
            string name = nameQueue.Dequeue();
            Stack<Dictionary<string, string>> stack = queue.Dequeue();
            Console.WriteLine($"\n{name} steps up to the desk with a stack of {stack.Count} dictionaries.");
            int dictCount = 1;
            do
            {
                Console.WriteLine($"{name} places dictionary {dictCount} on the desk, containing these word(s):");
                foreach (KeyValuePair<string, string> entry in stack.Pop())
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
                dictCount++;
            } while (stack.Count > 0);
        } while (queue.Count > 0);


    }
}
