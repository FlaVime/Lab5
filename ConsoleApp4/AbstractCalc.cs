public abstract class AbstractCalc
{
    public double _Num1 { get; set; }
    public double _Num2 { get; set; }
    public string? Model { get; protected set; }
    public abstract double Plus();
    public abstract double Minus();
    public abstract double Multiply();
    public abstract double Divide();
}
