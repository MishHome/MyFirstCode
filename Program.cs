using MyFirstCode;

class Programm
{
    static void Main(string[] args)
    {
        MyCalculator myCalc = new MyCalculator();

        do
        {
            int x = 0, y = 0;
            string? message;
            for (int i = 0; i < 2; i++)
            {

                while (true)
                {
                    string ask = i == 0 ? "первое" : "второе";
                    Console.Write($"Введите {ask} число: ");
                    string? str = Console.ReadLine();
                    int digit;
                    if (MyCalculator.ControllerInputDigitInt(str, out digit, out message) == false)
                    {
                        Console.WriteLine(message);
                        continue;
                    }
                    else
                    {
                        if (i == 0)
                            x = digit;
                        else
                            y = digit;

                        break;
                    }
                }
            }

            string? strOperationInput;
            while (true)
            {
                Console.Write($"Введите операцию: {String.Join(" ", MyCalculator.StringArrayOperations)} или q для выхода: ");
                strOperationInput = Console.ReadLine();

                var isValid = MyCalculator.ControllerInputOperation(strOperationInput, out string? ErrorMessage);
                if (isValid == false)
                {
                    if (strOperationInput != null && strOperationInput.Equals("q"))
                        return;
                    Console.WriteLine(ErrorMessage);
                    continue;
                }
                else
                {
                    if (strOperationInput != null && strOperationInput.Equals("q"))
                        return;
                    break;
                }

            }


            if (strOperationInput == null)
                break;

            myCalc.Operation(x, y, strOperationInput);
            Console.WriteLine(myCalc.MessegeResult());

            Console.ReadLine();
        }
        while (true);

        Environment.Exit(0);
    }


}
