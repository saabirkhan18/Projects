using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class A
    {
        public void Display()
        {
            Console.WriteLine("hello");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Display();
            Console.ReadLine();
        }
    }
}
