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
        //static void Main(string[] args)
        //{
        //    var T1 = new Thread(PrintStar);
        //    T1.Start();

        //    var T2 = new Thread(PrintPlus);
        //    T2.Start();

        //    T1.Join();
        //    T2.Join();

        //    // main thread will always execute after T1 and T2 completes its execution
        //    Console.WriteLine("Ending main thread");

        //    Console.ReadLine();

        //}

        //static void PrintStar()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.Write(" * ");    
        //    }

        //}

        //static void PrintPlus()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Console.Write(" + "); 
        //    }
        //}
        #endregion

        #region Using Monitor.Enter - Monitor.Exit
        //static bool isStarPrinted = false;
        //static object locker = new object();

        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        new Thread(PrintStar).Start();
        //    }

        //    PrintStar();
        //    PrintStar();

        //    Console.ReadLine();
        //}

        //static void PrintStar()
        //{
        //    Monitor.Enter(locker);
        //    try
        //    {
        //        if (!isStarPrinted)
        //        {
        //            Console.WriteLine(" * ");
        //            isStarPrinted = true;
        //        }
        //    }
        //    finally
        //    {
        //        Monitor.Exit(locker);
        //    }

        //}
        #endregion

        #region Using Lock
        //// lock statement works similar to Monitor.Enter and Exit. Its just a syntax change
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

        #region Mutex
        //static void Main()
        //{
        //    // Naming a Mutex makes it available computer-wide. Use a name that's
        //    // unique to your company and application (e.g., include your URL).
        //    using (var mutex = new Mutex(false, "PSH"))
        //    {
        //        // Wait a few seconds if contended, in case another instance
        //        // of the program is still in the process of shutting down.
        //        if (!mutex.WaitOne())
        //        {
        //            Console.WriteLine("Another instance of the app is running. Bye!");
        //            return;
        //        }

        //        RunProgram();
        //    }

        //    new Thread(RunProgram).Start();

        //    Console.ReadLine();
        //}
        //static void RunProgram()
        //{
        //    Console.WriteLine("Running. Press Enter to exit");
        //}
        #endregion

        #region Semaphore
        // Nightclub example
        static SemaphoreSlim _sem = new SemaphoreSlim(3); // Capacity of 3
        
        static void Main()
        {
            for (int i = 1; i <= 5; i++) new Thread(Enter).Start(i);
            Console.ReadLine();
        }

        static void Enter(object id)
        {
            Console.WriteLine(id + " wants to enter");
            _sem.Wait();
            Console.WriteLine(id + " is in!"); // Only three threads
            Thread.Sleep(2000 * (int)id); // can be here at
            Console.WriteLine(id + " is leaving"); // a time.
            _sem.Release();
        }

        #endregion

    }
}
