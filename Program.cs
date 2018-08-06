using System;
using romanNumbers;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNum r1 = new RomanNum(2);
            int i1 = r1.GetValue();
            string s1 = r1.Roman;
            r1.UpdateValue(10);
            s1 = r1.Roman;
            i1 = r1.GetValue();
            r1.UpdateValue("III");
            s1 = r1.Roman;
            i1 = r1.GetValue();
            BinNumber b1 = new BinNumber(1);
            int i2 = b1.GetValue();
            string s2 = b1.Bin;
            b1.UpdateValue(5);
            s2 = b1.Bin;
            i2 = b1.GetValue();
            b1.UpdateValue("1101h1");
            s2 = b1.Bin;
            i2 = b1.GetValue();
        }
    }
}
