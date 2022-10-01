namespace MyFirstCode
{
    public class MyCalculator
    {
        long X { get; set; }
        long Y { get; set; }
        string Operator { get; set; } = "";
        public long? Resultlong { get; private set; }
        public float? ResultFloat { get; private set; }

        public static string[] StringArrayOperations => new string[] { "+", "-", "*", "/", "%" };

        public MyCalculator() { }

        public string MessegeResult()
        {
            string err = "операция не корректна";
            string res = $"{Resultlong ?? ResultFloat}";
            string s = $"{X} {Operator} {Y} = {res ?? err}";
            return s;
        }

        public static long? ParsingInput(string s)
        {
            if (s == null)
                return null;

            if (long.TryParse(s, out long y))
            {
                if (y >= int.MaxValue)
                    return null;
                else
                    return y;
            }
            else
                return null;
        }


        public void Operation(long x, long y, string _operator)
        {

            ResultFloat = null;
            Resultlong = null;
            X = x;
            Y = y;
            Operator = _operator;

            switch (_operator)
            {
                case "+":
                    Resultlong = AddDigit(x, y);
                    break;
                case "-":
                    Resultlong = SubtractDigit(x, y);
                    break;
                case "*":
                    Resultlong = MultiplicationDigit(x, y);
                    break;
                case "/":
                    ResultFloat = DivisionDigit(x, y);
                    break;
                case "%":
                    Resultlong = RemainsDigit(x, y);
                    break;
                default:
                    break;
            }
        }

        static long AddDigit(long a, long b) => a + b;
        static long SubtractDigit(long a, long b) => a - b;
        static long MultiplicationDigit(long a, long b)
        {
            // int res;
            try
            {
                // res = a * b;
                long res2 = (long)a * (long)b;
                return res2;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);  
                throw ex.InnerException ?? ex;
            }

        }

        static float? DivisionDigit(long a, long b)
        {
            if (b == 0)
                return null;

            if (a % b == 0)
                return (float)(a / b);
            else
                return (float)a / (float)b;
        }
        static long? RemainsDigit(long a, long b)
        {
            if (b == 0)
                return null;
            else
                return a % b;
        }

        public static bool ControllerInputOperation(string? strInput, out string? ErrorMessage)
        {

            ErrorMessage = null;
            if (strInput == null)
                return false;

            foreach (string _operator in StringArrayOperations)
            {
                if (_operator.Equals(strInput))
                    return true;
            }
            ErrorMessage = "Ошибка ввода";
            return false;

        }

        public static bool ControllerInputDigitInt(string? str, out int IntDigitA, out string? ErrorMessage)
        {
            ErrorMessage = null;
            IntDigitA = 0;
            if (str == null)
                return false;
            if (int.TryParse(str, out int a) == false)
            {
                ErrorMessage = "Ошибка ввода";
                return false;
            }
            else
            {
                IntDigitA = a;
                return true;
            }

        }

    }
}
