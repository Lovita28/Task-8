using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tugas_8___Multithread
{
    class Program
    {
        public void DoTest()
        {
            Thread t1 =
                new Thread(
                    new ThreadStart(Incrementer));
            Thread t2 =
                new Thread(
                    new ThreadStart(Decrementer));
            t1.Start();
            t2.Start();
        }
        public void Incrementer()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Penambah : {0} ", i);
                Thread.Sleep(1000);
            }
        }
        public void Decrementer()
        {
            for (int i = 10; i >= 0; i--)
            {
                if (i == 5)
                {
                    Console.WriteLine("Decrement End");
                    i = 0;
                }
                else
                {
                    System.Console.WriteLine("Pengurangan : {0} ", i);
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            Program t = new Program();
            Console.WriteLine("Start");
            t.DoTest();
            Console.ReadKey();
        }
    }
}
