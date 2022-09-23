using MyFirstCode;
using System;
using System.Net.Mail;
using System.Runtime.InteropServices;

class Programm
{
    static void Main(string[] args)
    {
        MyCalculator myCalc = new MyCalculator();
        string? operation = "";
        
        while (operation.Equals("q") ==false )
        {
            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите операцию или q для выхода: ");
            operation = Console.ReadLine();
            if (operation == null)
                return;

            if (operation.Equals("+"))
            {
                myCalc.AddDigit(x, y);
                Console.WriteLine(myCalc.Message);

            }
            else if (operation.Equals("-"))
            {
                myCalc.SubtractDigit(x, y);
                Console.WriteLine(myCalc.Message);
            }
            else if (operation.Equals("*"))
            {
                myCalc.MultiplicationDigit(x, y);
                Console.WriteLine(myCalc.Message);
            }
            else if (operation.Equals("/"))
            {
                myCalc.DivisionDigit(x, y);
                Console.WriteLine(myCalc.Message);
            }
            Console.ReadLine();
        }

        
    }
}
