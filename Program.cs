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
            //ввод и проверка корректности введеного значения
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
            Console.Write("Введите операцию: + , - ,  * , / , % или q для выхода: ");
            operation = Console.ReadLine();          
            if (operation == null)
                return;


            //ветвление для выбора функции
            switch (operation)
            {
                case "+":
                    myCalc.AddDigit(x, y);
                    break;
                case "-":
                    myCalc.SubtractDigit(x, y);
                    break;
                case "*":
                    myCalc.MultiplicationDigit(x, y);
                    break;
                case "/":
                    myCalc.DivisionDigit(x, y);
                    break;
                case "%":
                    myCalc.RemainsDigit(x, y);
                    break;
                default:
                    Console.WriteLine("Вы ввели недопустимый символ");
                    continue;
                   
            }
           

            Console.WriteLine(myCalc.Message);
            Console.ReadLine();
        }

        Environment.Exit(0);
    }
}
