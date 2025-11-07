using System.Reflection.PortableExecutable;

namespace example;

public class Program
{
    static void Main(string[] args)
    {
    }
    public static void ValidateGrade(double grade)
    {
        if (grade < 0 || grade > 4)
        {
            throw new ArgumentOutOfRangeException(nameof(grade));
        }
    }
    public static char GetGradeLetter(double gpa)
    {
        ValidateGrade(gpa);
        char toReturn = ' ';
        if (gpa <= 4 && gpa >= 3.7)
        {
            toReturn = 'A';
        }
        else if (gpa <= 3.6 && gpa >= 2.7)
        {
            toReturn = 'B';
        }
        else if (gpa <= 2.6 && gpa >= 1.7)
        {
            toReturn = 'C';
        }
        else if (gpa <= 1.6 && gpa >= 1)
        {
            toReturn = 'D';
        }
        else
        {
            toReturn = 'F';
        }
        return toReturn;
    }

}