using MyFirstCode;

class Programm
{
    static void Main(string[] args)
    {
        MyCalculator myCalc = new MyCalculator();
        string? operation = "";
        string? s = "";
        
        while (operation.Equals("q") ==false )
        {
            Console.Write("Введите первое число: ");
            int x;
            s = Console.ReadLine();
            if(s == null || s.Equals("q"))
                break;
            if (int.TryParse(s, out x) ==false)
            {
                Console.WriteLine("Ошибка ввода");
                continue; 
            }

            Console.Write("Введите второе число: ");
            int y;
            s = Console.ReadLine();
            if (s == null || s.Equals("q"))
                break;
            if (int.TryParse(s, out y) ==false)
            {
                Console.WriteLine("Ошибка ввода");
                continue;
            }
            Console.Write("Введите операцию + - * / % или q для выхода: ");
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
            else if (operation.Equals("%"))
            {
                myCalc.RemainsDigit(x, y);
                Console.WriteLine(myCalc.Message);
            }
            else
            {
                Console.WriteLine("Вы ввели недопустимый символ");
                continue;
            }
            Console.ReadLine();
        }

        Environment.Exit(0);
    }
}
