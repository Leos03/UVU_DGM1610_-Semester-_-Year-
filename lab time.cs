using System;

public class program
{
    public void Main()
    {
        Console.WriteLine("Ello there");
        DoMath(10, 4);
        DoMath(20, 7);
        DoMath(30, 15);
        Compare(4, 3);
        Compare(3, 4);
    }

    public void DoMath(int value, int value2) {
        var number = value + value2;
        Console.WriteLine(number);
    }