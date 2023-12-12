using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinaryAnalysis
{
    public class VerifyBinary
    {
        public bool ValidateBinary(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Input is empty");
                return false;
            }

            bool isBianry = Regex.IsMatch(value, "^[01]+$");
            if (!isBianry)
            {
                Console.WriteLine("Input is not binary");
                return false;
            }

            int zeroCount = 0, oneCount = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '0')
                    zeroCount++;
                else if (value[i] == '1')
                    oneCount++;
            }

            if (zeroCount != oneCount)
            {
                Console.WriteLine("Input is not binary");
                return false;
            }

            Console.WriteLine("Input is binary string");
            return true;
        }
    }
}
