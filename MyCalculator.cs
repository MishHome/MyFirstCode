using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        int SubtractDigit(int a, int b)
        {
            int z = a - b;
            return z;

        }

    }
}
