using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_splitter;
using binary_and_decimal;

namespace binary_octal
{
    internal class octal_and_binary
    {
        splitter splitter = new splitter();
        binary_decimal binary_decimal = new binary_decimal();

        public string binary_to_octal(string value)
        {
            var (binaryWhole, binaryFraction) = splitter.bin_splitter(value);
            //----Whole----
            var binaryWholeContainer = new List<string>() { };
            string binaryTemp = "";

            for (int i = binaryWhole.Length  - 1; i >= 0; i--)
            {
                if (binaryTemp.Length == 3)
                {
                    binaryWholeContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp = binaryWhole[i] + binaryTemp;
            }

            if (String.IsNullOrEmpty(binaryTemp) != true)
            {
                for (var i = 0; i <= 3; i++)
                {
                    if (binaryTemp.Length == 4)
                    {
                        binaryWholeContainer.Add(binaryTemp);
                        break;
                    }
                    binaryTemp = "0" + binaryTemp;
                }
            }

            string octalWhole = "";
            foreach (string i in binaryWholeContainer)
            {
                double y = binary_decimal.binary_to_decimal(i);
                octalWhole = y.ToString() + octalWhole;
            }

            //----Fraction----
            var binaryFractionContainer = new List<string>() { };
            binaryTemp = "";

            foreach (var i in binaryFraction)
            {
                if (binaryTemp.Length == 3)
                {
                    binaryFractionContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp += i;
            }

            if (String.IsNullOrEmpty(binaryTemp) != true)
            {
                for(int i = 0; i <= 4; i++)
                {
                    if (binaryTemp.Length == 3)
                    {
                        binaryFractionContainer.Add(binaryTemp);
                        break;
                    }
                    binaryTemp += "0";
                }
            }

            string octalFraction = ".";
            foreach (var i in binaryFractionContainer)
            {
                double x = binary_decimal.binary_to_decimal(i);
                octalFraction += x.ToString();
            }

            return octalWhole + octalFraction;
        }
    }
}
