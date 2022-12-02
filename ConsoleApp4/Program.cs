using System;

class Program
{
    static void Calculation_standart()
    {
        int str;
        bool cod = true;
        CalculateSt obj = new CalculateSt();
        double a, b;

        while (cod == true)
        {
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║   CalculationSt Menu    ║");
            Console.WriteLine("╠═════════════════════════╣");
            Console.WriteLine("║      0-> Plus           ║");
            Console.WriteLine("║      1-> Minus          ║");
            Console.WriteLine("║      2-> Multiply       ║");
            Console.WriteLine("║      3-> Divide         ║");
            Console.WriteLine("║      4-> Back           ║");
            Console.WriteLine("╚═════════════════════════╝");
            str = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (str)
            {
                case 0:
                    InputS1:
                    Console.WriteLine("First Num");
                    string s1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(s1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputS1;
                    }

                    InputS2:
                    Console.WriteLine("Seсond Num");
                    string s2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(s2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputS2;
                    }
                    obj.SetNum1(a);
                    obj.SetNum2(b);
                    obj.Plus();
                    break;

                case 1:
                    InputM1:
                    Console.WriteLine("First Num");
                    string m1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(m1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputM1;
                    }

                    InputM2:
                    Console.WriteLine("Seсond Num");
                    string m2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(m2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputM2;
                    }

                    obj.SetNum1(a);
                    obj.SetNum2(b);
                    obj.Minus();
                    break;

                case 2:
                    InputMl1:
                    Console.WriteLine("First Num");
                    string ml1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(ml1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputMl1;
                    }

                    InputMl2:
                    Console.WriteLine("Seсond Num");
                    string ml2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(ml2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputMl2;
                    }

                    obj.SetNum1(a);
                    obj.SetNum2(b);
                    obj.Multiply();
                    break;

                case 3:
                    InputD1:
                    Console.WriteLine("First Num");
                    string d1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(d1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputD1;
                    }

                    InputD2:
                    Console.WriteLine("Seсond Num");
                    string d2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(d2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputD2;
                    }

                    obj.SetNum1(a);
                    obj.SetNum2(b);
                    obj.Divide();
                    break;

                case 4:
                    cod = false;
                    break;

                default:
                    break;
            }
        }

    }
    static void Calculation_ingener()
    {
        int str;
        bool cod = true;
        CalculateIn obk = new CalculateIn();
        while (cod == true)
        {
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║   CalculationIn Menu    ║");
            Console.WriteLine("╠═════════════════════════╣");
            Console.WriteLine("║      0-> Plus           ║");
            Console.WriteLine("║      1-> Minus          ║");
            Console.WriteLine("║      2-> Multiply       ║");
            Console.WriteLine("║      3-> Divide         ║");
            Console.WriteLine("║      4-> sToFahrenheit  ║");
            Console.WriteLine("║      5-> Ctg            ║");
            Console.WriteLine("║      6-> Back           ║");
            Console.WriteLine("╚═════════════════════════╝");
            str = int.Parse(Console.ReadLine());
            Console.Clear();
            double a, b;
            switch (str)
            {
                case 0:
                    InputS1:
                    Console.WriteLine("First Num");
                    string s1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(s1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputS1;
                    }

                    InputS2:
                    Console.WriteLine("Seсond Num");
                    string s2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(s2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputS2;
                    }

                    obk.SetNum1(a);
                    obk.SetNum2(b);
                    obk.Plus();
                    break;

                case 1:
                    InputM1:
                    Console.WriteLine("First Num");
                    string m1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(m1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputM1;
                    }

                    InputM2:
                    Console.WriteLine("Seсond Num");
                    string m2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(m2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputM2;
                    }

                    obk.SetNum1(a);
                    obk.SetNum2(b);
                    obk.Minus();
                    break;

                case 2:
                    InputMl1:
                    Console.WriteLine("First Num");
                    string ml1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(ml1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputMl1;
                    }

                    InputMl2:
                    Console.WriteLine("Seсond Num");
                    string ml2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(ml2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputMl2;
                    }

                    obk.SetNum1(a);
                    obk.SetNum2(b);
                    obk.Multiply();
                    break;

                case 3:
                    InputD1:
                    Console.WriteLine("First Num");
                    string d1 = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(d1);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputD1;
                    }

                    InputD2:
                    Console.WriteLine("Seсond Num");
                    string d2 = Console.ReadLine();
                    try
                    {
                        b = Convert.ToDouble(d2);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputD2;
                    }

                    obk.SetNum1(a);
                    obk.SetNum2(b);
                    obk.Divide();
                    break;

                case 4:
                    InputCelc:
                    Console.WriteLine("First Num");
                    string celc = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(celc);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputCelc;
                    }
                    obk.SetNum1(a);
                    obk.ToFahrenheit(a);
                    break;

                case 5:
                    InputCtg:
                    Console.WriteLine("First Num");
                    string ctg = Console.ReadLine();
                    try
                    {
                        a = Convert.ToDouble(ctg);
                    }
                    catch
                    {
                        Error();
                        System.Threading.Thread.Sleep(900);
                        Console.Clear();
                        goto InputCtg;
                    }
                    obk.SetNum1(a);
                    obk.Ctg(a);
                    break;

                case 6:
                    cod = false;
                    break;

                default:
                    break;
            }
        }

    }
    static void Menu()
    {
        int a;
        bool cod = true;
        while (cod == true)
        {
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║     Calculation Menu    ║");
            Console.WriteLine("╠═════════════════════════╣");
            Console.WriteLine("║0-> Calculation standart ║");
            Console.WriteLine("║1-> Calculation_ingener  ║");
            Console.WriteLine("║        2-> Back         ║");
            Console.WriteLine("╚═════════════════════════╝");

            a = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (a)
            {
                case 0:
                    Calculation_standart();
                    break;
                case 1:
                    Calculation_ingener();
                    break;
                case 2:
                    cod = false;
                    break;

                default:
                    break;
            }
        }
    }

    static void Error()
    {
        Console.WriteLine("Input Error!");
    }

    static void Main(string[] args)
    {
        int swt;
        bool cod = true;
        while (cod == true)
        {
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║       Start Program     ║");
            Console.WriteLine("╠═════════════════════════╣");
            Console.WriteLine("║        0---> Menu       ║");
            Console.WriteLine("║        1---> Exit       ║");
            Console.WriteLine("╚═════════════════════════╝");
            swt = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (swt)
            {
                case 0:
                    Menu();
                    break;
                case 1:
                    cod = false;
                    break;
                default:
                    Error();
                    break;
            }
        }
    }
}