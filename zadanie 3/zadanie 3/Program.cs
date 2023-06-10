using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("podaj wagę w kg");
        double w;
        
        w = inputValue();
        Console.WriteLine("podaj wzrost w metrach");
        double h;
        
        h = inputValue();
        double bMI;
        
        bMI = w / (h * h);
        Console.Write("BMI=");
        Console.WriteLine(bMI);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

