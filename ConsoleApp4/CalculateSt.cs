using System;

class CalculateSt
{
    private double _Num1;
    private double _Num2;
    public void SetNum1(double Num)
    {
        _Num1 = Num;
    }
    public void SetNum2(double Num)
    {
        _Num2 = Num;
    }
    public double GetNum1()
    {
        return _Num1;
    }
    public double GetNum2()
    {
        return _Num2;
    }
    public void Plus()
    {

        double res = _Num1 + _Num2;
        Console.WriteLine("Answer: " + res);
        Console.WriteLine();
        Console.WriteLine("press any key");
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        Console.Clear();
    }
    public void Minus()
    {
        double res = _Num1 - _Num2;
        Console.WriteLine("Answer: " + res);
        Console.WriteLine();
        Console.WriteLine("press any key");
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        Console.Clear();
    }
    public void Multiply()
    {
        double res = _Num1 * _Num2;
        Console.WriteLine("Answer: " + "{0, 0:f3}", res);
        Console.WriteLine();
        Console.WriteLine("press any key");
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        Console.Clear();
    }
    public void Divide()
    {
        double res = _Num1 / _Num2;
        Console.WriteLine("Answer: " + "{0, 0:f3}", res);
        Console.WriteLine();
        Console.WriteLine("press any key");
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        Console.Clear();
    }
}