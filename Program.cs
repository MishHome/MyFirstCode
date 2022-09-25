using MyFirstCode;

class Programm
{
    static void Main(string[] args)
    {
        MyCalculator myCalc = new MyCalculator();

        do
        {
            int x = ControllerInputDigitInt("Введите первое число: ");
            int y = ControllerInputDigitInt("Введите второе число: ");

            string? operation = ControllerInputOperation(myCalc.StringArrayOperations);
            if (operation == null)
                break;         

            myCalc.Operation(x, y, operation);
            Console.WriteLine(myCalc.MessegeResult());

            Console.ReadLine();
        }
        while (true);

        Environment.Exit(0);
    }

    static string? ControllerInputOperation(string[] stringArray) 
    {
       
        string stringMessage = $"Введите операцию: {String.Join(" ",stringArray)} или q для выхода:";
        while (true)
        {
            Console.Write(stringMessage);
            string? strInput = Console.ReadLine();
            
            if (strInput == null || strInput.Equals("q") )
                return null;

            foreach (string _operator in stringArray) 
            { 
                if(_operator.Equals(strInput))
                    return _operator;

               
            } 
                Console.WriteLine("Ошибка ввода");
          
        }
    }

    static int ControllerInputDigitInt(string s)
    {
        while (true)
        {
            Console.Write(s);
            var str = Console.ReadLine();

            if (int.TryParse(str, out int a) == false)
            {
                Console.WriteLine("Ошибка ввода");
                continue;
            }
            else
                return a;
        }
    }
}
