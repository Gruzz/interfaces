using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using romanNumbers;

namespace Interfaces
{
    class BinNumber
    {
        /// <summary>
        /// convert decimal to binary
        /// </summary>
        /// <param name="decIn">decimal number</param>
        /// <returns></returns>
        static string getBin(int decIn)
        {
            char[] bin = new char[sizeof(int) * 8];
            for (int i = 31; i >= 0; i--)
            {
                if ((decIn & 1) == 1)
                    bin[i] = '1';
                else
                    bin[i] = '0';
                decIn >>= 1;
            }
            return new string(bin);
        }
        /// <summary>
        /// convert from binary to decimal
        /// </summary>
        /// <param name="binToDec">binary number</param>
        /// <returns></returns>
        static int getDec(string binToDec)
        {
            if ((binToDec == null)||(binToDec == ""))
                throw new ExeptionRomanNumber(ExeptionRes.nullOrEmpty);
            int res = 0;
            for (int i = 0; i < binToDec.Length; i++)
            {
                if (binToDec[i] == '1') res += 1;
                if (i != binToDec.Length - 1) res <<= 1;
            }
            return res;
        }
    }
}
