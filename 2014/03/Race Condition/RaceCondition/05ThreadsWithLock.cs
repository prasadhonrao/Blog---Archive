using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        // Multiple threads accessing shared variable using static method

        #region Thread Join
        static void Main(string[] args)
        {
            var T1 = new Thread(PrintStar);
            T1.Start();

            var T2 = new Thread(PrintPlus);
            T2.Start();

            T1.Join();
            T2.Join();

            // main thread will always execute after T1 and T2 completes its execution
            Console.WriteLine("Ending main thread");

            Console.ReadLine();

        }

        static void PrintStar()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" * ");    
            }
            
        }

        static void PrintPlus()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(" + "); 
            }
        }
        #endregion

        #region Using Lock
        //static bool isStarPrinted = false;
        //static object locker = new object();

        //static void Main(string[] args)
        //{
        //    new Thread(PrintStar).Start();
        //    PrintStar();

        //    Console.ReadLine();
        //}

        //static void PrintStar()
        //{
        //    lock (locker) // Thread safe code
        //    {
        //        if (!isStarPrinted)
        //        {
        //            Console.WriteLine(" * ");
        //            isStarPrinted = true;
        //        }
        //    }
        //} 
        #endregion
        
    }
}
