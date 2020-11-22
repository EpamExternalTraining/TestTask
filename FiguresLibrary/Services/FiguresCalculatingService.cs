using FiguresLibrary.Models.Figures;
using FiguresLibrary.Models.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FiguresLibrary.Services
{
    public static class FiguresCalculatingService
    {

        #region Calculate medium values

        /// <summary>
        /// Calculates medium Perimeter for list of figures
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>medium Perimeter</returns>
        public static double CalculateMediumPerimeter(IEnumerable<IFigure> figures)
        {
            return CalculatePerimeter(figures) / figures.Count();
        }

        /// <summary>
        /// Calculates medium Area for list of figures
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>medium Area</returns>
        public static double CalculateMediumArea(IEnumerable<IFigure> figures)
        {
            return CalculateArea(figures) / figures.Count();
        }

        #endregion

        #region Calculate values

        /// <summary>
        /// Calculates Perimeter for list of figures
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>Perimeter</returns>
        public static double CalculatePerimeter(IEnumerable<IFigure> figures)
        {
            double result = 0;
            foreach (IFigure figure in figures)
                result += figure.GetPerimeter();
            return result;
        }

        /// <summary>
        /// Calculates Area for list of figures
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>Area</returns>
        public static double CalculateArea(IEnumerable<IFigure> figures)
        {
            double result = 0;
            foreach (IFigure figure in figures)
                result += figure.GetArea();
            return result;
        }

        #endregion

        #region Calculate the best figure type with values


        /// <summary>
        /// Calculates best figure type among perimeter
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>Type of figure</returns>
        public static string CalculateBestFigureTypePerimeter(IEnumerable<IFigure> figures)
        {

            List<Circle> circles = new List<Circle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Square> squares = new List<Square>();
            List<Trapezoid> trapezoids = new List<Trapezoid>();

            foreach (IFigure figure in figures)
            {
                if (figure.GetType() == typeof(Circle)) circles.Add((Circle)figure);
                else if (figure.GetType() == typeof(Rectangle)) rectangles.Add((Rectangle)figure);
                else if (figure.GetType() == typeof(Square)) squares.Add((Square)figure);
                else trapezoids.Add((Trapezoid)figure);
            }

            List<KeyValuePair<double, string>> results = new List<KeyValuePair<double, string>>();

            results.Add(new KeyValuePair<double, string>(CalculatePerimeter(circles), "Circle"));
            results.Add(new KeyValuePair<double, string>(CalculatePerimeter(rectangles), "Rectangle"));
            results.Add(new KeyValuePair<double, string>(CalculatePerimeter(squares), "Square"));
            results.Add(new KeyValuePair<double, string>(CalculatePerimeter(trapezoids), "Trapezoid"));

            results.Sort((s1, s2) => -s1.Key.CompareTo(s2.Key));

            return results[0].Value.ToString();
        }


        /// <summary>
        /// Calculates best figure type among area
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>Type of figure</returns>
        public static string CalculateBestFigureTypeArea(IEnumerable<IFigure> figures)
        {

            List<Circle> circles = new List<Circle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Square> squares = new List<Square>();
            List<Trapezoid> trapezoids = new List<Trapezoid>();

            foreach (IFigure figure in figures)
            {
                if (figure.GetType() == typeof(Circle)) circles.Add((Circle)figure);
                else if (figure.GetType() == typeof(Rectangle)) rectangles.Add((Rectangle)figure);
                else if (figure.GetType() == typeof(Square)) squares.Add((Square)figure);
                else trapezoids.Add((Trapezoid)figure);
            }

            List<KeyValuePair<double, string>> results = new List<KeyValuePair<double, string>>();

            results.Add(new KeyValuePair<double, string>(CalculateArea(circles), "Circle"));
            results.Add(new KeyValuePair<double, string>(CalculateArea(rectangles), "Rectangle"));
            results.Add(new KeyValuePair<double, string>(CalculateArea(squares), "Square"));
            results.Add(new KeyValuePair<double, string>(CalculateArea(trapezoids), "Trapezoid"));

            results.Sort((s1, s2) => -s1.Key.CompareTo(s2.Key));

            return results[0].Value.ToString();
        }

        #endregion

        #region Calculate the best figure type with medium values


        /// <summary>
        /// Calculates best figure type among medium perimeter
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>Type of figure</returns>
        public static string CalculateBestFigureTypeMediumPerimeter(IEnumerable<IFigure> figures)
        {

            List<Circle> circles = new List<Circle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Square> squares = new List<Square>();
            List<Trapezoid> trapezoids = new List<Trapezoid>();

            foreach (IFigure figure in figures)
            {
                if (figure.GetType() == typeof(Circle)) circles.Add((Circle)figure);
                else if (figure.GetType() == typeof(Rectangle)) rectangles.Add((Rectangle)figure);
                else if (figure.GetType() == typeof(Square)) squares.Add((Square)figure);
                else trapezoids.Add((Trapezoid)figure);
            }

            List<KeyValuePair<double, string>> results = new List<KeyValuePair<double, string>>();

            results.Add(new KeyValuePair<double, string>(CalculateMediumPerimeter(circles), "Circle"));
            results.Add(new KeyValuePair<double, string>(CalculateMediumPerimeter(rectangles), "Rectangle"));
            results.Add(new KeyValuePair<double, string>(CalculateMediumPerimeter(squares), "Square"));
            results.Add(new KeyValuePair<double, string>(CalculateMediumPerimeter(trapezoids), "Trapezoid"));

            results.Sort((s1, s2) => -s1.Key.CompareTo(s2.Key));

            return results[0].Value.ToString();
        }


        /// <summary>
        /// Calculates best figure type among medium area
        /// </summary>
        /// <param name="figures">List of figures</param>
        /// <returns>Type of figure</returns>
        public static string CalculateBestFigureTypeMediumArea(IEnumerable<IFigure> figures)
        {

            List<Circle> circles = new List<Circle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Square> squares = new List<Square>();
            List<Trapezoid> trapezoids = new List<Trapezoid>();

            foreach (IFigure figure in figures)
            {
                if (figure.GetType() == typeof(Circle)) circles.Add((Circle)figure);
                else if (figure.GetType() == typeof(Rectangle)) rectangles.Add((Rectangle)figure);
                else if (figure.GetType() == typeof(Square)) squares.Add((Square)figure);
                else trapezoids.Add((Trapezoid)figure);
            }

            List<KeyValuePair<double, string>> results = new List<KeyValuePair<double, string>>();

            results.Add(new KeyValuePair<double, string>(CalculateMediumArea(circles), "Circle"));
            results.Add(new KeyValuePair<double, string>(CalculateMediumArea(rectangles), "Rectangle"));
            results.Add(new KeyValuePair<double, string>(CalculateMediumArea(squares), "Square"));
            results.Add(new KeyValuePair<double, string>(CalculateMediumArea(trapezoids), "Trapezoid"));

            results.Sort((s1, s2) => -s1.Key.CompareTo(s2.Key));

            return results[0].Value.ToString();
        }

        #endregion
    }
}
