using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace BigNumbersLib
{
    public class BigNumber
    {
        private Sign? sign;
        private List<ulong> numberArray;
        private ulong? mod;
        private bool isPresent;
        public BigNumber(string InputString)
        {
            try
            {
                if (MainMisc.NotANumber(InputString))
                {
                    throw new Exception("incorrect number input data");
                }
            }
            catch
            {
                sign = null;
                mod = null;
                numberArray = null;
                isPresent = false;
            }

            List<byte> ByteArray = new List<byte>();

            if (InputString.StartsWith("-"))
            {
                sign = Sign.Minus;
                InputString = InputString.Substring(1);
            }

            foreach (var c in InputString.Reverse())
            {
                ByteArray.Add(Convert.ToByte(c.ToString()));
            }

        }
    }
    public enum Sign
    {
        Minus = -1,
        Plus = 1
    }
    public class MainMisc
    {
        public static bool NotANumber(string Input)
        {
            string pattern = "^[-123456789]?\\d*$";
            Regex NumberChecker = new Regex(pattern);
            return NumberChecker.IsMatch(Input);
        }
        public static List<ulong> ListByteToUlong(List<byte> Input)
        {
            List<ulong> Output = new List<ulong>();

            return Output;
        }
    }
}
