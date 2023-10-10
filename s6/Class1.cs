using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s6
{
    internal class Class1
    {
        
        public static int Sum(int x)
        {
            int s = 0;
            s += x;
            return s;
        }

        public static int Sum(int x, int y)
        {
            int s = 0;
            s += x + y;
            return s;
        }
         
        public int Add(int x,int y)
        {
            return x + y;
        }

        public double Add(double x,double y)
        {
            return x + y;
        }

    }
}

