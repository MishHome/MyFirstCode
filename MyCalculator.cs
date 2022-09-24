namespace MyFirstCode
{
    internal class MyCalculator
    {

        public MyCalculator()
        {
            message = String.Empty;
        }


        int X { get; set; }
        int Y { get; set; }
        int Result { get; set; }
        
        float ResultFloat { get; set; }
        bool FlagFloat { get; set; }



        string message;
        public string Message 
        {
            get 
            { 
                return message;
            }
            set 
            {
               if (FlagFloat)
                    message = $"{X} {value} {Y} = {ResultFloat}";
               else
                    message = $"{X} {value} {Y} = {Result}";
            } 
        }




        public void AddDigit(int a, int b)
        {

            X = a;
            Y = b;
            Result  = a + b;
            Message = "+";
            FlagFloat = false;
        }

        public void SubtractDigit(int a, int b)
        {
            X = a;
            Y = b;
            Result = a - b;
            Message = "-";
            FlagFloat = false;
        }
        public void MultiplicationDigit(int a, int b)
        {
            X = a;
            Y = b;
            Result = a * b;
            Message = "*";
            FlagFloat = false;
        }
        public void DivisionDigit(int a, int b)
        {
            X = a;
            Y = b;
            if (b != 0)
            {
                if (a % b == 0)
                {
                    Result = a / b;
                    FlagFloat = false;
                }
                else
                {
                    ResultFloat = (float)a / (float)b;
                    FlagFloat = true;
                }
                Message = "/";
            }
            else 
            {
                this.message = $"{X}/{Y} = нет значения. Делить на нуль нельзя!";
            }
 
        }
       

        public void RemainsDigit(int a ,int b)
        {
            X = a;
            Y = b;

            if (b != 0)
            {
                Result = a % b;
                Message = "%";
            }
            else
            {
                this.message = $"{X}/{Y} = нет значения. Делить на нуль нельзя!";
            }

            FlagFloat = false;


        }

    }
}
