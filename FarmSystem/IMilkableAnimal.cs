using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    /// <summary>
    /// Interface which exposes method to milk animals
    /// </summary>
    public interface IMilkableAnimal
    {
        #region  Public Methods

        void ProduceMilk();

        #endregion
    }
}