using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_splitter;
using binary_and_decimal;

namespace Binary_Calculator_v2
{
    internal class hexa_and_binary
    {
        splitter splitter = new splitter();
        binary_decimal binary_decimal = new binary_decimal();
        public string binary_to_hexa(string value)
        {
            var (binaryWhole, binaryFraction) = splitter.bin_splitter(value);
            //-----whole----
            var binaryWholeContainer = new List<string>() { };
            string binaryTemp = "";

            for (int i = binaryWhole.Length - 1; i >= 0; i--)
            {
                if (binaryTemp.Length == 4)
                {
                    binaryWholeContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp = binaryWhole[i] + binaryTemp;
            }

            if (String.IsNullOrEmpty(binaryTemp) != true)
            {
                for (var i = 0; i <= 4; i++)
                {
                    if (binaryTemp.Length == 4)
                    {
                        binaryWholeContainer.Add(binaryTemp);
                        break;
                    }
                    binaryTemp = "0" + binaryTemp;
                }
            }

            string hexadecimalWhole = "";
            foreach (var i in binaryWholeContainer)
            {
                double y = binary_decimal.binary_to_decimal(i);
                char convert = splitter.hexa_replacer((int)y);
                hexadecimalWhole = convert.ToString() + hexadecimalWhole;
            }
            
            //-----Fraction----
            var binaryFractionContainer = new List<string>() { };
            binaryTemp = "";

            foreach(var i in binaryFraction)
            {
                if (binaryTemp.Length == 4)
                {
                    binaryFractionContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp += i;
            }

            return hexadecimalWhole; // not final yet :)
        }
    }
}
