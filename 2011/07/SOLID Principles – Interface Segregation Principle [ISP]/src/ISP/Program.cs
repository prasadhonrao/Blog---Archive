using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IDoor
    {
        bool IsDoorOpen { get; set; }
        void Lock();
        void Unlock();
    }

    public class SimpleDoor : IDoor
    {
        public bool IsDoorOpen
        {
            // property implementation 
        }

        public void Lock()
        {
            // method implementation goes here
        }

        public void Unlock()
        {
            // method implementation goes here
        }
    }

    class AdvancedDoor : IDoor, ITimerFunction
    {
        public bool IsDoorOpen
        {
            get;
            set;
        }

        public void Lock()
        {
            // Method implementation goes here...
        }

        public void Unlock()
        {
            // Method implementation goes here...
        }

        public void TimerFunction()
        {
        }
    }


    public interface ITimerFunction
    {
        void TimerFunction(); 
    }
}

