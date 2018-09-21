using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double maths = 60;
            double physics = 65;
            double chemistry = 70;

            double average = (maths + physics + chemistry) / 3;
            Console.WriteLine("average of "+maths+" , "+physics+" and "+chemistry+" is"+average);

        }
    }
}
