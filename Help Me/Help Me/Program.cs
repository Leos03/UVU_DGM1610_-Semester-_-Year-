﻿using System;

public class Program
{
    public void Main()
    {
        Console.WriteLine("Oh ell there");
        DoMath(14, 2);
        DoMath(21, 5);
        DoMath(42, 15);
    }

    public void DoMath (int value, int value2) {
        var number = value + value2;
        Console.WriteLine(number);
    }

    public void Compare (int value, int value2) { 
        if (value > value2) {
            Console.WriteLine("True. the first greater.");
        }
    }
}