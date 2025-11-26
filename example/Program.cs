using System.IO;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
        string[] names = new string[] { "Joe", "John", "Jane", "John", "Joe" };


        // Automatically filter out duplicates.
        HashSet<string> theHashSet = new HashSet<string>();

        foreach (string name in names)
        {
            theHashSet.Add(name);
        }
        Console.WriteLine("--- HashSet ---");
        foreach (string name in theHashSet)
        {
            Console.WriteLine(name);
        }

        // Automatically filter out duplicates and sort.
        SortedSet<string> theSortedSet = new SortedSet<string>();

        foreach (string name in names)
        {
            theSortedSet.Add(name);
        }
        Console.WriteLine("--- SortedSet ---");
        foreach (string name in theSortedSet)
        {
            Console.WriteLine(name);
        }

        Queue<string> theQueue = new Queue<string>();
        foreach (string name in theSortedSet)
        {
            theQueue.Enqueue(name);
        }
        Console.WriteLine("--- Queue ---");
        while (theQueue.Count > 0)
        {
            Console.WriteLine(theQueue.Dequeue());
        }

        Stack<string> theStack = new Stack<string>();
        foreach (string name in theSortedSet)
        {
            theStack.Push(name);
        }
        Console.WriteLine("--- Stack ---");
        while (theStack.Count > 0)
        {
            Console.WriteLine(theStack.Pop());
        }
    }
}
