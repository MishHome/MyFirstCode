using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCode
{
    internal class MyCalculator
    {
        //public MyCalculator()
        //{
        //}

        int X { get; set; }
        int Y { get; set; }

        int Result { get; set; }

        int AddDigit(int a, int b) 
        {
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
