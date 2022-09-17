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
        public int D { get; set; }
        public int C { get; set; }
        public int SubtractDigit(int a, int b)
        {
            D = a;
            C = b;
            int z = a - b;
            return z;

        }

    }
}
