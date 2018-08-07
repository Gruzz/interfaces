using System;
using romanNumbers;

namespace Interfaces
{
    public class BinNumber : INumber
    {
        public BinNumber() { bin = "0"; dec = 0; }
        public BinNumber(int a) { bin = getBin(a); dec = a; }
        public BinNumber(string a) { bin = a; dec = getDec(a); }
        //field for integer representation of number
        private int dec;
        public int Dec
        {
            get { return dec; }
            set
            {
                dec = value;
                bin = getBin(dec);
            }
        }
        //field for binary representation of number
        private string bin;
        public string Bin
        {
            get { return bin; }
            private set { bin = value; dec = getDec(bin); }
        }
        /// <summary>
        /// convert decimal to binary
        /// </summary>
        /// <param name="decIn">decimal number</param>
        /// <returns></returns>
        private static string getBin(int decIn)
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
        private static int getDec(string binToDec)
        {
            if ((binToDec == null)||(binToDec == ""))
                throw new ExeptionRomanNumber(ExeptionRes.nullOrEmpty);
            if (binToDec.Length > 32)
                throw new ExeptionRomanNumber(ExeptionRes.longString);
            int res = 0;
            for (int i = 0; i < binToDec.Length; i++)
            {
                if ((binToDec[i] != '1')&&(binToDec[i] != '0'))
                    throw new ExeptionRomanNumber(String.Format(ExeptionRes.unsupportedChar, binToDec[i]));
                if (binToDec[i] == '1') res += 1;
                if (i != binToDec.Length - 1) res <<= 1;
            }
            return res;
        }

        public int GetValue()
        {
           return dec;
        }

        public void UpdateValue(int newVal)
        {
            dec = newVal;
            bin = getBin(newVal);
        }

        public void UpdateValue(string newVal)
        {
            dec = getDec(newVal);
            bin = newVal;
        }
    }
}
