using FiguresLibrary.Models.Figures;
using FiguresLibrary.Models.Interfaces;
using FiguresLibrary.Services;
using FileWorkerLibrary.Models.FileWorker;
using FileWorkerLibrary.Models.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnitTest
{
    [TestClass]
    public class FigureTests
    {
        private readonly string _filePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Resources", "figures.txt");
        private readonly IFigureFileWorker _fileWorker = new CSVFileFigureFileWorker();

        [DataRow("Error")]
        [DataTestMethod, Description("Reading CSV data and catch expection")]
        public void ReadingCSVDataFromTextFile_Exception(string fileName)
        {
            Assert.ThrowsException<Exception>(() => _fileWorker.GetFigures(fileName));
        }


        [DataRow("ErrorAsync")]
        [DataTestMethod, Description("Reading CSV data asynchronously and catch expection")]
        public void ReadingCSVDataFromTextFileAsync_Exception(string fileName)
        {
            Assert.ThrowsExceptionAsync<Exception>(() => _fileWorker.GetFiguresAsync(fileName));
        }


        [DataRow(null)]
        [DataTestMethod, Description("Reading CSV data and catch ArgumentNullExpection")]
        public void ReadingCSVDataFromTextFile_ArgumentException(string fileName)
        {
            Assert.ThrowsException<ArgumentNullException>(() => _fileWorker.GetFigures(null));
        }


        [DataRow(null)]
        [DataTestMethod, Description("Reading CSV data asynchronousle and catch ArgumentNullException")]
        public void ReadingCSVDataFromTextFileAsync_ArgumentException(string fileName)
        {
            Assert.ThrowsExceptionAsync<ArgumentNullException>(() => _fileWorker.GetFiguresAsync(null));
        }


        [DynamicData(nameof(GetFigures), DynamicDataSourceType.Method)]
        [DataTestMethod, Description("Reading CSV data and check for correct reading")]
        public void ReadingCSVDataFromTextfile_CorrectReading(params IFigure[] testFigures)
        {
            Assert.AreNotEqual(null, _fileWorker.GetFigures(_filePath));

            List<IFigure> figures = _fileWorker.GetFigures(_filePath).ToList();

            Assert.AreEqual(figures.Count, testFigures.Length);
            for (int i = 0; i < figures.Count; ++i)
            {
                Assert.AreEqual(figures[i], testFigures[i]);
            }
        }


        [DataRow(100.00, 16.60)]
        [DataTestMethod, Description("Reading CSV data and check for correct medium perimeter and area")]
        public void ReadingCSVDataFromTextfile_CorrectMediumCalculatings(double expectedMediumArea, double expectedMediumPerimeter, params IFigure[] testFigures)
        {
            List<IFigure> figures = _fileWorker.GetFigures(_filePath).ToList();
            Assert.AreEqual(FiguresCalculatingService.CalculateArea(figures), expectedMediumArea, 1e-2);
            Assert.AreEqual(FiguresCalculatingService.CalculateMediumPerimeter(figures), expectedMediumPerimeter, 1e-2);

        }

        [DataRow("Circle")]
        [DataTestMethod, Description("Reading CSV data and check for the best figure type amon Area")]
        public void ReadingCSVDataFromTextFile_CorrectBestFigureType(string expectedType)
        {
            List<IFigure> figures = _fileWorker.GetFigures(_filePath).ToList();

            Assert.AreEqual(FiguresCalculatingService.CalculateBestFigureTypeArea(figures), expectedType);
        }

        [DataRow("Circle")]
        [DataTestMethod, Description("Reading CSV data and check for the best figure type among medium Perimeter")]
        public void ReadingCSVDataFromTextFile_CorrectBestFigureTypeMedium(string expectedType)
        {
            List<IFigure> figures = _fileWorker.GetFigures(_filePath).ToList();

            Assert.AreEqual(FiguresCalculatingService.CalculateBestFigureTypeMediumPerimeter(figures), expectedType);
        }

        public static IEnumerable<object[]> GetFigures()
        {
            yield return new IFigure[]
            {
                new Circle(5),
                new Rectangle(2,5),
                new Square(2),
                new Trapezoid(2,1,5,5)
            };
        }
    }

}
