using MyFirstCode;
class Programm
{
    static void Main(string[] args)
    {


        MyCalculator myCalc = new MyCalculator();

        int a, b;
        a = 10;
        b = 3;

        int z = myCalc.AddDigit(a, b);

        

        string View = $"Результат сложения числа {myCalc.X} и {myCalc.Y} равен {z}";
        Console.WriteLine(View);

        z = myCalc.SubtractDigit(a, b);

         View = $"Результат вычитания  числа {myCalc.X} и {myCalc.Y} равен {z}";

        Console.WriteLine(View);

        z = myCalc.MultiplicationDigit(a, b);

        View = $"Результат умножения числа {myCalc.X} и {myCalc.Y} равен {z}";

        Console.WriteLine(View);

        //*********************************
        Console.ReadLine();
    }
}
