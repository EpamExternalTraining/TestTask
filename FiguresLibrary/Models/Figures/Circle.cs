using FiguresLibrary.Models.Interfaces;
using System;

namespace FiguresLibrary.Models.Figures
{
    public class Circle : IFigure
    {

        /// <summary>
        /// Variable for Radius of Circle
        /// </summary>
        private double _radius;

        /// <summary>
        /// Property, witch sets the variable for Radius of Circle
        /// </summary>
        public double Radius 
        {
            get => _radius;
            set
            {
                if (value <= 0) throw new ArgumentException("Radius of circle must be bigger than zero!!!");
                _radius = value;
            }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="radius">Radius size</param>
        public Circle(double radius = 1)
        {   
            Radius = radius;
        }


        public double GetArea() => Math.PI * Math.Pow(_radius, 2);

        public double GetPerimeter() => 2 * Math.PI * _radius;

        public override bool Equals(object obj)
        {
            bool result = false;
            Circle other = obj as Circle;

            if (other!=null) result = other.Radius == this.Radius;

            return result;
        }
    }
}
