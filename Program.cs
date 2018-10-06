using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingDemo
{
    class Program
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} => {2}", num1, num2, (num1 + num2));
        }

        //public int Add(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        public void Add(int num1, int num2, int num3)
        {
            Console.WriteLine("{0} + {1} + {2} => {3}", num1, num2, num3, (num1 + num2 + num3));
        }

        public void Add(float num1, float num2)
        {
            Console.WriteLine("{0} + {1} => {2}", num1, num2, (num1 + num2));
        }

        public void Add(int num1, float num2)
        {
            Console.WriteLine("{0} + {1} => {2}", num1, num2, (num1 + num2));
        }

        public void Add(float num1, int num2)
        {
            Console.WriteLine("{0} + {1} => {2}", num1, num2, (num1 + num2));
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.Add(10, 20);
            p.Add(10, 20, 30);
            p.Add(23.65f, 45.23f);
            p.Add(10, 45.67f);
            p.Add(23.56f, 78);

            Console.ReadKey();
        }
    }
}
