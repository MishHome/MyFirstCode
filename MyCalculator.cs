namespace MyFirstCode
{
    internal class MyCalculator
    {


        public int X { get; set; }
        public int Y { get; set; }



        public int AddDigit(int a, int b)
        {
            X = a;
            Y = b;
            int z = a + b;
            return z;

        }
        
        public int SubtractDigit(int a, int b)
        {
            X = a;
            Y = b;
            int z = a - b;
            return z;

        }
        public int MultiplicationDigit(int a, int b)
        {
            X = a;
            Y = b;
            int z = a * b;
            return z;
        }
        public int DivisionDigit(int a, int b)
        {
            X = a;
            Y = b;
            int z = a / b;
            return z;
        }
    }
}
