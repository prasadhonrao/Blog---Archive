namespace DIP_Good
{
    using System;

    public interface IReader
    {
        string Read();
    }

    public class KeyboardReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }

    public interface IWriter
    {
        void Write(string output);
    }

    public class PrinterWriter : IWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(string.Format("Writing to printer {0}", output));
        }
    }

    public class FileWriter : IWriter
    {
        public void Write(string output)
        {
            Console.WriteLine(string.Format("Writing to file {0}", output));
        }
    }


    public class Copy
    {
        private IReader reader;
        private IWriter writer;

        public Copy(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void DoWork()
        {
            this.writer.Write(this.reader.Read());
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Send output to Printer
            IReader r = new KeyboardReader();
            IWriter pw = new PrinterWriter();
            Copy cp = new Copy(r, pw);
            cp.DoWork();

            // Send output to FileStream now 
            IWriter fw = new FileWriter();
            Copy cpf = new Copy(r, fw);
            cpf.DoWork();

            Console.ReadLine();
        }
    }
}
