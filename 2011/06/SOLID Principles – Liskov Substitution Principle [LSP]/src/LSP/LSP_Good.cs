using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP
{
    public class LSP_Good
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


    public class Square : LSP_Good
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