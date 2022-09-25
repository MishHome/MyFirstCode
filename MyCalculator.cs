namespace MyFirstCode
{
    public class MyCalculator
    {
        int X { get; set; }
        int Y { get; set; }
        string Operator { get; set; } = "";
        public int? ResultInt { get; private set; }
        public float? ResultFloat { get; private set; }

        public string[] StringArrayOperations => new string[] { "+", "-", "*", "/", "%" };

    public MyCalculator() { }

        public string MessegeResult()
        {
            string err = "операция не корректна";
            string res = $"{ResultInt ?? ResultFloat}";
            string s = $"{X} {Operator} {Y} = {res ?? err}";
            return s;
        }

        public int? ParsingInput(string s) 
        {
            if (s == null)
                return null;

            if (int.TryParse(s, out int y))
               return y;
            else
               return null;
        }


        public void Operation(int x, int y, string _operator)
        {

            ResultFloat = null;
            ResultInt = null;
            X = x;
            Y = y;
            Operator = _operator;

            switch (_operator)
            {
                case "+":
                    ResultInt = AddDigit(x, y);
                    break;
                case "-":
                    ResultInt = SubtractDigit(x, y);
                    break;
                case "*":
                    ResultInt = MultiplicationDigit(x, y);
                    break;
                case "/":
                    ResultFloat = DivisionDigit(x, y);
                    break;
                case "%":
                    ResultInt = RemainsDigit(x, y);
                    break;
                default:
                    break;
            }
        }

        public int AddDigit(int a, int b) => a + b;
        public int SubtractDigit(int a, int b) => a - b;
        public int MultiplicationDigit(int a, int b) => a * b;

        public float? DivisionDigit(int a, int b)
        {
            if (b == 0)
                return null;

            if (a % b == 0)
                return (float)(a / b);
            else
                return (float)a / (float)b;
        }
        public int? RemainsDigit(int a, int b)
        {
            if (b == 0)
                return null;
            else
                return a % b;
        }

    }
}
