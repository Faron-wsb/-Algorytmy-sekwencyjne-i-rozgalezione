using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("podaj a:");
        a = (int)inputValue();
        Console.WriteLine("podaj b:");
        b = (int)inputValue();
        Console.WriteLine("podaj c:");
        c = (int)inputValue();
        Console.WriteLine("podaj d:");
        d = (int)inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            x = a * d + b * c;
            y = b * d;
            Console.Write("x=");
            Console.WriteLine(x);
            Console.Write("y=");
            Console.WriteLine(y);
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

