using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y;

        Console.WriteLine("podaj x");
        x = inputValue();
        Console.WriteLine("podaj y");
        y = inputValue();
        double dodawanie, odejmowanie, mnozenie, dzielenie;
        int z;
        double q;

        Console.WriteLine("Wybierz jakie działanie chcesz wykonać:");
        Console.WriteLine("Dodawanie - 1");
        Console.WriteLine("Odejmowanie - 2");
        Console.WriteLine("Mnożenie - 3");
        Console.WriteLine("Dzielenie - 4");
        z = (int)inputValue();
        if (z == 1)
        {
            dodawanie = x + y;
            Console.WriteLine(dodawanie);
        }
        else
        {
            if (z == 2)
            {
                odejmowanie = x - y;
                Console.WriteLine(odejmowanie);
            }
            else
            {
                if (z == 3)
                {
                    mnozenie = x * y;
                    Console.WriteLine(mnozenie);
                }
                else
                {
                    if (z == 4)
                    {
                        if (y == 0)
                        {
                            Console.Write(x);
                            Console.Write("/");
                            Console.WriteLine("0");
                        }
                        else
                        {
                            dzielenie = x / y;
                            Console.WriteLine(dzielenie);
                        }
                    }
                    else
                    {
                        Console.WriteLine("to działanie nie istnieje");
                    }
                }
            }
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
