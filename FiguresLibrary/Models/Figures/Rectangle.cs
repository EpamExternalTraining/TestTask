using FiguresLibrary.Models.Interfaces;
using System;

namespace FiguresLibrary.Models.Figures
{
    public class Rectangle : IFigure
    {

        /// <summary>
        /// Variable for size of the first side of rectangle
        /// </summary>
        private double _sizeOfFirstSide;

        /// <summary>
        /// Variable for size of the second side of rectangle
        /// </summary>
        private double _sizeOfSecondSide;

        /// <summary>
        /// Property for size of the first side of rectangle
        /// </summary>
        public double SizeOfFirstSide
        {
            get => _sizeOfFirstSide;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of first side of reactangle must be bigger than zero!!!");
                _sizeOfFirstSide = value;
            }
        }

        /// <summary>
        /// Property for size of the second side of rectangle
        /// </summary>
        public double SizeOfSecondSide
        {
            get => _sizeOfSecondSide;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of second side of rectangle must be bigger than zero!!!");
                _sizeOfSecondSide = value;
            }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sizeOfFirstSide">Size of the first side of rectangle</param>
        /// <param name="sizeOfSecondSide">Size of the second side of rectangle</param>
        public Rectangle(double sizeOfFirstSide = 1, double sizeOfSecondSide = 2)
        {
            SizeOfFirstSide = sizeOfFirstSide;
            SizeOfSecondSide = sizeOfSecondSide;
        }


        public double GetArea() => _sizeOfFirstSide * _sizeOfSecondSide;
        public double GetPerimeter() => (_sizeOfFirstSide + _sizeOfSecondSide) * 2;

        public override bool Equals(object obj)
        {
            bool result = false;
            Rectangle other = obj as Rectangle;

            if (other != null) result = other.SizeOfFirstSide == this.SizeOfFirstSide && 
                                        other.SizeOfSecondSide == this.SizeOfSecondSide;

            return result;
        }
    }
}
