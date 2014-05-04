namespace LSP_Rectangle
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.SetHeight(10);
            rect.SetWidth(2);
            System.Console.WriteLine(rect.CalculateArea());
            
            // Below instantiation can be returned by some factory method
            Rectangle rect1 = new Square(); 
            rect1.SetHeight(10);
            rect1.SetWidth(5);
            System.Console.WriteLine(rect1.CalculateArea());

            Console.ReadLine();
        }
    }

    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void SetHeight(int height)
        {
            this.Height = height;
        }

        public virtual void SetWidth(int width)
        {
            this.Width = width;
        }

        public virtual int CalculateArea()
        {
            return this.Height * this.Width;
        }
    }

    public class Square : Rectangle
    {
        public override void SetHeight(int height)
        {
            this.Height = height;
            this.Width = height;
        }

        public override int CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
