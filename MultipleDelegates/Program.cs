using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleDelegates
{
    public delegate void show_delegate();
    public delegate void Calculation(int a,int b);
    class Program
    {
    
        public static void show()
        {
            Console.WriteLine("Hello");
        }
        public static void add(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition is:{0}",result);
        }
        static void Main(string[] args)
        {
            show_delegate sd = new show_delegate(show);
            sd();

            Calculation cl = new Calculation(add);
            cl(10,30);

        }
    }
}
