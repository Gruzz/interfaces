using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface INumber
    {
        /// <summary>
        /// Get integer value of number
        /// </summary>
        /// <returns></returns>
        int GetValue();
        /// <summary>
        /// Set new integer value of a number
        /// </summary>
        /// <param name="newVal"></param>
        void UpdateValue(int newVal);        
    }
}
