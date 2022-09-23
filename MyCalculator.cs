namespace MyFirstCode
{
    internal class MyCalculator
    {

        public MyCalculator()
        {
            message = String.Empty;
        }


        public int X { get; set; }
        public int Y { get; set; }
        public float Result { get; set; }
        public float D { get; set; }
        public float C { get; set; }


        string message;
        public string Message 
        {
            get 
            { 
                return message;
            }
            set 
            {
               message = $"{X} {value} {Y} = {Result}";
            } 
        }




        public void AddDigit(int a, int b)
        {

            X = a;
            Y = b;
            Result  = a + b;
            Message = "+";

        }

        public void SubtractDigit(int a, int b)
        {
            X = a;
            Y = b;
            Result = a - b;
            Message = "-";

        }
        public void MultiplicationDigit(int a, int b)
        {
            X = a;
            Y = b;
            Result = a * b;
            Message = "*";

        }
        public void DivisionDigit(int a, int b)
        {
            X = a;
            Y = b;
            if (b != 0)
            {
                Result = a / b;
                Message = "/";
            }
            else 
            {
                this.message = $"{X}/{Y} = нет значения. Делить на нуль нельзя!";
            }

        }
        public void DivisionDigit(float a, float b)
        {
             Console.Write("введите число: ");
            C = a;
            D = b;
            if (b != 0)
            {
                Result = a / b;
                Message = "/";
            }
            else
            {
                this.message = $"{C}/{D} = нет значения. Делить на нуль нельзя!";

            }

        }
    }
}
