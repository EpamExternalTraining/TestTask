namespace FiguresLibrary.Models.Interfaces
{
    public interface IFigure
    {
        /// <summary>
        /// Calculates the Area
        /// </summary>
        /// <returns>Area of the Figure</returns>
        public double GetArea();

        /// <summary>
        /// Calculates the Perimeter
        /// </summary>
        /// <returns>Perimeter of the Figure</returns>
        public double GetPerimeter();
    }
}
