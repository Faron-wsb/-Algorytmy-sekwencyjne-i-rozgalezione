using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wpisz kolejno boki trójkąta");
        double a, b, c;

        a = inputValue();
        b = inputValue();
        c = inputValue();
        if (a == b || b == c || c == a)
        {
            Console.WriteLine("trójkąt jest równoboczny");
        }
        else
        {
            Console.WriteLine("trójkąt nie jest równoboczny");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
