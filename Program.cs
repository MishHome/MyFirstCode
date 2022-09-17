using MyFirstCode;
using System.Net.Mail;

class Programm
{
    static void Main(string[] args)
    {


        MyCalculator myCalc = new MyCalculator();

        int a, b;
        a = 10; b = 3;

        myCalc.AddDigit(a, b);      
        Console.WriteLine(myCalc.Message );

        myCalc.SubtractDigit(a, b);
        Console.WriteLine(myCalc.Message);


        a = 5; b = 7;
        myCalc.MultiplicationDigit(a, b);
        Console.WriteLine(myCalc.Message);

        a = 9; b = 3;
        myCalc.DivisionDigit(a, b);
        Console.WriteLine(myCalc.Message);


        a = 9; b = 0;
        myCalc.DivisionDigit(a, b);
        Console.WriteLine(myCalc.Message);

        a = 5; b =2;
        myCalc.DivisionDigit(a, b);
        Console.WriteLine(myCalc.Message);

        a = 1; b = 2;
        myCalc.DivisionDigit(a, b);
        Console.WriteLine(myCalc.Message);





        // Console. Hight mountains and beautifull light star.I love walk in the cute PARIS street.it is interesting read because
        // Mary writes this programm.
        //*********************************
        Console.ReadLine();
    }
}
