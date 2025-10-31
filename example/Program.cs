namespace example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Types Program!\n1. Enter 1 to see an example of an integer\n2. Enter 2 to see an example of a float\n3. Enter 3 to see an example of a string\n4. Enter 4 to see an example of a boolean\n5. Enter Q to quit the program");
        string selection;
        string prompt = "Please make a selection: ";
        do
        {
            GetInput(ref prompt, out selection);
            if (selection == "1")
            {
                Console.WriteLine("1 is an Integer!");
            }
            else if (selection == "2")
            {
                Console.WriteLine("3.14 is a Float!");
            }
            else if (selection == "3")
            {
                Console.WriteLine("'Hello' is a String!");
            }
            else if (selection == "4")
            {
                Console.WriteLine("True is a Boolean!");
            }
            else
            {
                Console.WriteLine(selection == "Q" ? "" : "That is invalid, please try again!");
            }
        } while (selection != "Q");
    }
    /// <summary>
    /// Prompt the user for an input, continue until one is provided.
    /// </summary>
    /// <returns>
    /// The gathered input.
    /// </returns>
    /// <param name="prompt">
    /// The prompt to show the user.
    /// </param>
    /// <param name="toReturn">
    /// The response.
    /// </param>
    static void GetInput(ref string prompt, out string toReturn)
    {
        do
        {
            Console.Write(prompt);
            toReturn = Console.ReadLine().Trim().ToUpper();
            if (toReturn.Length == 0)
            {
                Console.WriteLine("It doesn't look like you've given me a name!");
            }
        } while (toReturn.Length == 0);
    }
}
