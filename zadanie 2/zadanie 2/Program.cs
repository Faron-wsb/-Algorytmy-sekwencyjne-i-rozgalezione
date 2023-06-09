using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("podaj pole koła");
        double a;

        a = inputValue();
        double obwód;

        obwód = Math.Sqrt(a / Math.PI) * 2 * Math.PI;
        Console.WriteLine("obwód koła wynosi");
        Console.WriteLine(obwód);
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

