using MyFirstCode;

class Programm
{
    static void Main(string[] args)
    {
        MyCalculator myCalc = new MyCalculator();

        do
        {
            int x = MyCalculator.ControllerInputDigitInt("Введите первое число: ");
            int y = MyCalculator.ControllerInputDigitInt("Введите второе число: ");

            string? operation = MyCalculator.ControllerInputOperation(MyCalculator.StringArrayOperations);
            
            if (operation == null)
                break;         

            myCalc.Operation(x, y, operation);
            Console.WriteLine(myCalc.MessegeResult());

            Console.ReadLine();
        }
        while (true);

        Environment.Exit(0);
    }

   
}
