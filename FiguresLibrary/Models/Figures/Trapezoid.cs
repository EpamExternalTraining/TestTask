using FiguresLibrary.Models.Interfaces;
using System;

namespace FiguresLibrary.Models.Figures
{
    public class Trapezoid : IFigure
    {

        /// <summary>
        /// Variable for size of larger base of trapezoid
        /// </summary>
        private double _sizeOfLargerBase;

        /// <summary>
        /// Variable for size of shorter base of trapezoid
        /// </summary>
        private double _sizeOfShorterBase;

        /// <summary>
        /// Variable for size of left side of trapezoid
        /// </summary>
        private double _sizeOfLeftSide;

        /// <summary>
        /// Variable for size of right side of trapezoid
        /// </summary>
        private double _sizeOfRightSide;



        /// <summary>
        /// Property for size of the larger base of trapezoid
        /// </summary>
        public double SizeOfLargerBase
        {
            get => _sizeOfLargerBase;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of larger base must be bigger than zero!!!");
                _sizeOfLargerBase = value;
            }
        }

        /// <summary>
        /// Property for size of the shorter base of trapezoid
        /// </summary>
        public double SizeOfShorterBase
        {
            get => _sizeOfShorterBase;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of shorter base must be bigger than zero!!!");
                _sizeOfShorterBase = value;
            }
        }

        /// <summary>
        /// Property for size of left side of trapezoid
        /// </summary>
        public double SizeOfLeftSide
        {
            get => _sizeOfLeftSide;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of left side must be bigger than zero!!!");
                _sizeOfLeftSide = value;
            }
        }

        /// <summary>
        /// Property for size of the right side of trapezoid
        /// </summary>
        public double SizeOfRightSide
        {
            get => _sizeOfRightSide;
            set
            {
                if (value <= 0) throw new ArgumentException("Size of right side must be bigger than zero!!!");
                _sizeOfRightSide = value;
            }
        }



        public Trapezoid(double sizeOfLargerBase = 2, double sizeOfShorterBase = 1, double sizeOfLeftSide = 5, double sizeOfRightSide = 5)
        {
            SizeOfLargerBase = sizeOfLargerBase;
            SizeOfShorterBase = sizeOfShorterBase;
            SizeOfLeftSide = sizeOfLeftSide;
            SizeOfRightSide = sizeOfRightSide;
        }

        public double GetArea()
        {
            var temp = _sizeOfLargerBase - _sizeOfShorterBase;
            return ((_sizeOfShorterBase + _sizeOfLargerBase) / 2)
                    * Math.Sqrt(
                            Math.Pow(_sizeOfLeftSide, 2) - Math.Pow(
                                                                (Math.Pow(temp, 2) + Math.Pow(_sizeOfLeftSide, 2) - Math.Pow(_sizeOfRightSide, 2))
                                                                / (2 * temp)
                                                           ,2)
                               );
        }

        public double GetPerimeter() => _sizeOfLargerBase + _sizeOfShorterBase + _sizeOfLeftSide + _sizeOfRightSide;


        public override bool Equals(object obj)
        {
            bool result = false;
            Trapezoid other = obj as Trapezoid;

            if (other != null) result = other.SizeOfLargerBase == this.SizeOfLargerBase &&
                                        other.SizeOfShorterBase == this.SizeOfShorterBase &&
                                        other.SizeOfLeftSide == this.SizeOfLeftSide &&
                                        other.SizeOfRightSide == this.SizeOfRightSide;

            return result;
        }
    }
}
