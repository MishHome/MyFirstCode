﻿using MyFirstCode;
class Programm
{
    static void Main(string[] args)
    {


        MyCalculator myCalc = new MyCalculator();

        int a, b;
        a = 10;
        b = 3;

        int z = myCalc.AddDigit(a, b);

        a = 4;
        b = 7;

        string View = $"Результат сложения числа {myCalc.X} и {myCalc.Y} равен {z}";
        Console.WriteLine(View);

        z = myCalc.SubtractDigit(b, a);

        string View2 = $"Результат вычитания  числа {myCalc.D} и {myCalc.C} равен {z}";

        Console.WriteLine(View2);

        //*********************************
        Console.ReadLine();
    }
}
