using FiguresLibrary.Models.Interfaces;
using System;

namespace FiguresLibrary.Models.Figures
{
    public class Square : IFigure
    {
        /// <summary>
        /// Variable for size of one side of square
        /// </summary>
        private double _sizeOfOneSide;


        /// <summary>
        /// Property for one side of square
        /// </summary>
        public double SizeOfOneSide
        {
            get => _sizeOfOneSide;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of one side of square must be bigger than zero!!!");
                _sizeOfOneSide = value;
            }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sizeOfOneSide">Size of one side of square</param>
        public Square(double sizeOfOneSide = 1)
        {
            SizeOfOneSide = sizeOfOneSide;
        }


        public double GetArea() => Math.Pow(_sizeOfOneSide, 2);
        public double GetPerimeter() => _sizeOfOneSide * 4;

        public override bool Equals(object obj)
        {
            bool result = false;
            Square other = obj as Square;

            if (other != null) result = other.SizeOfOneSide == this.SizeOfOneSide;

            return result;
        }
    }
}
