using FiguresLibrary.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FileWorkerLibrary.Models.Interfaces
{
    public interface IFigureFileWorker
    {

        /// <summary>
        /// Read figures from CSV file
        /// </summary>
        /// <param name="fileName">CSV file name</param>
        /// <returns>IEnumarable of figures</returns>
        IEnumerable<IFigure> GetFigures(string fileName);


        /// <summary>
        /// Read figures from CSV file asynchronously
        /// </summary>
        /// <param name="fileName">CSV file name</param>
        /// <returns>Task<IEnumarable> of figures</returns>
        Task<IEnumerable<IFigure>> GetFiguresAsync(string fileName);
    }
}
