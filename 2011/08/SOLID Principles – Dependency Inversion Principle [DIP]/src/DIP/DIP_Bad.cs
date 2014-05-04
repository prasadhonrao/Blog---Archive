namespace DIP_Bad
{
    using System;

    public class DIP_Bad
    {
        //static void Main(string[] args)
        //{
        //    Copy badCopy = new Copy();
        //    badCopy.DoWork();
        //    Console.ReadLine();
        //}
    }

    public class KeyboardReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }

    public class PrinterWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }
    }

    public class Copy
    {
        private KeyboardReader reader;
        private PrinterWriter writter;

        public void DoWork()
        {
            this.reader = new KeyboardReader();
            this.writter = new PrinterWriter();
            this.writter.Write(this.reader.Read());
        }
    }


}
