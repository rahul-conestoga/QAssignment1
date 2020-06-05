using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Rectangle
    {
        private int Length;
        private int Width;

        public Rectangle()
        {
            this.Length = 1;
            this.Width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }

        public int GetLength() {
            return this.Length;
        }
        public int SetLength(int length) {
            if(length > 0) this.Length = length;
            return this.Length;
        }
        public int GetWidth() {
            return this.Width;
        }
        public int SetWidth(int width) {
            if(width > 0) this.Width = width;
            return this.Width;
        }
        public int GetPerimeter() {
            return (2 * this.Width) + (2 * this.Length);
        } 
        public int GetArea()
        {
            return this.Width * this.Length;
        }
    }
}
