using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacktraceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();           
            
        }

        static void Method1()
        {
            Console.WriteLine("In Method 1");
            System.Threading.Thread.Sleep(20000);
            Method2();
        }
        static void Method2()
        {
            Console.WriteLine("In Method 2");
            System.Threading.Thread.Sleep(20000);
            Method3();
        }
        static void Method3()
        {
            Console.WriteLine("In Method 3");
            System.Threading.Thread.Sleep(20000);
        }
    }
}
