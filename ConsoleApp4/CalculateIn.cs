using System;

class CalculateIn : CalculateSt
{
    public void ToFahrenheit(double celsGrad)
    {
        double res = (celsGrad * 9 / 5) + 32;
        Console.WriteLine("Answer: " + "{0, 0:f3}", res);
        Console.WriteLine();
        Console.WriteLine("press any key");
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        Console.Clear();
    }

    public void Ctg(double grad)
    {
        double res = 1 / Math.Tan(grad);
        Console.WriteLine("Answer: " + "{0, 0:f3}", res);
        Console.WriteLine();
        Console.WriteLine("press any key");
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        Console.Clear();
    }
}
