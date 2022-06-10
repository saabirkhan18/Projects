using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MultiThread
    {
        public void Display1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello display1: " + i);
                if (i == 5)
                {
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }
        public void Display2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello display2: " + i);
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------");
            MultiThread multiThread = new MultiThread();
            System.Threading.Thread thread1 = new System.Threading.Thread(multiThread.Display1);
            System.Threading.Thread thread2 = new System.Threading.Thread(multiThread.Display2);
            thread1.Start();
            thread2.Start();            
            Console.ReadLine();
        }
    }
}
