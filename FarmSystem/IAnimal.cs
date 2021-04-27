using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    /// <summary>
    /// Interface for Animal. 
    /// </summary>
    public interface IAnimal
    {
        #region Properties
        string Id { get; set; }
        int NoOfLegs { get; set; }
        #endregion

        #region Methods
        void Talk();
        void Run();
        #endregion
    }
}
