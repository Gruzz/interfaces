using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace romanNumbers
{
    public class ExeptionRomanNumber : Exception
    {
       
        public ExeptionRomanNumber(string message) : base (message)
        {
            
        }        
      
    }
}
