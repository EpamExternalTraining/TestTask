using FiguresLibrary.Models.Figures;
using FiguresLibrary.Models.Interfaces;
using FileWorkerLibrary.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileWorkerLibrary.Models.FileWorker
{
    public class CSVFileFigureFileWorker : IFigureFileWorker
    {

        private const string FIGURE_CIRCLE = "Circle";
        private const string FIGURE_RECTANGLE = "Rectangle";
        private const string FIGURE_SQUARE = "Square";
        private const string FIGURE_TRAPEZOID = "Trapezoid";

        public IEnumerable<IFigure> GetFigures(string fileName)
        {
            string[] lines;
            List<IFigure> figures = new List<IFigure>();

            try
            {
                lines = File.ReadAllLines(fileName);
            }
            catch (ArgumentNullException exc)
            {
                throw new ArgumentNullException("Argument cann`t be null", exc);
            }
            catch (Exception exc)
            {
                throw new Exception("Error reading data from file", exc);
            }

            if (lines == null || lines.Length == 0) throw new ArgumentNullException("File was empty");

            try
            {

                foreach (string line in lines)
                {
                    string[] tmp = line.Split(';');

                    switch (tmp[0])
                    {
                        case FIGURE_CIRCLE:
                            {
                                figures.Add(new Circle(double.Parse(tmp[1])));
                                break;
                            }
                        case FIGURE_RECTANGLE:
                            {
                                figures.Add(new Rectangle(double.Parse(tmp[1]), double.Parse(tmp[2])));
                                break;
                            }
                        case FIGURE_SQUARE:
                            {
                                figures.Add(new Square(double.Parse(tmp[1])));
                                break;
                            }
                        case FIGURE_TRAPEZOID:
                            {
                                figures.Add(new Trapezoid(double.Parse(tmp[1]), double.Parse(tmp[2]), double.Parse(tmp[3]), double.Parse(tmp[4])));
                                break;
                            }
                        default: break;
                    }
                }
            }
            catch(FormatException exc)
            {
                throw new FormatException("File has incorrect data format", exc);
            }
            return figures;
        }
        public async Task<IEnumerable<IFigure>> GetFiguresAsync(string fileName)
        {
            string[] lines;
            List<IFigure> figures = new List<IFigure>();

            try
            {
                lines = await File.ReadAllLinesAsync(fileName);
            }
            catch (ArgumentNullException exc)
            {
                throw new ArgumentNullException("Argument cann`t be null", exc);
            }
            catch (Exception exc)
            {
                throw new Exception("Error reading data from file", exc);
            }

            if (lines == null || lines.Length == 0) throw new ArgumentNullException("File was empty");

            try
            {

                foreach (string line in lines)
                {
                    string[] tmp = line.Split(';');

                    switch (tmp[0])
                    {
                        case FIGURE_CIRCLE:
                            {
                                figures.Add(new Circle(double.Parse(tmp[1])));
                                break;
                            }
                        case FIGURE_RECTANGLE:
                            {
                                figures.Add(new Rectangle(double.Parse(tmp[1]), double.Parse(tmp[2])));
                                break;
                            }
                        case FIGURE_SQUARE:
                            {
                                figures.Add(new Square(double.Parse(tmp[1])));
                                break;
                            }
                        case FIGURE_TRAPEZOID:
                            {
                                figures.Add(new Trapezoid(double.Parse(tmp[1]), double.Parse(tmp[2]), double.Parse(tmp[3]), double.Parse(tmp[4])));
                                break;
                            }
                        default: break;
                    }
                }
            }
            catch (FormatException exc)
            {
                throw new FormatException("File has incorrect data format", exc);
            }
            return figures;
        }
    }
}
