using System;
using romanNumbers;

namespace Interfaces
{
    public class DecNumber : INumber
    {
        public DecNumber() { dec = 0; }
        public DecNumber(int val) { dec = val; }
        private int dec;
        private string str;
        public int GetValue()
        {
            return dec;
        }
        public void UpdateValue(int newVal)
        {
            dec = newVal;
            str = dec.ToString();
        }
        public void UpdateValue(string newVal)
        {
            int val = 0;
            if (Int32.TryParse(str, out val))
            {
                str = newVal;
                dec = Int32.Parse(str);
            }
            else
                throw new ExeptionRomanNumber(Interfaces.ExeptionRes.notAnumber);
        }
        public string GetStrValue()
        {
            return str;
        }
    }
}
