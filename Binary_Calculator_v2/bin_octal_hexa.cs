using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_splitter;
using binary_and_decimal;
// merged both octal and hexadecimal code structure
// when binary to octal or hexa, the range(3-octal | 4-hexa) and sign(0-positive | 1-negative) should be specified
// when octal or hexa to binary, only the range should be specified
// might delete the other files later <06-12-24>

namespace binOctalHexa
{
    internal class bin_octal_hexa
    {
        splitter splitter = new splitter();
        binary_decimal binary_decimal = new binary_decimal();
        public string binary_to_OctalHexa(string value, int range, string sign)
        {
            var (binaryWhole, binaryFraction) = splitter.bin_splitter(value);
            //-----whole----
            var binaryWholeContainer = new List<string>() { };
            string binaryTemp = "";

            for (int i = binaryWhole.Length - 1; i >= 0; i--)
            {
                if (binaryTemp.Length == range)
                {
                    binaryWholeContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp = binaryWhole[i] + binaryTemp;
            }

            if (String.IsNullOrEmpty(binaryTemp) != true)
            {
                for (var i = 0; i <= range; i++)
                {
                    if (binaryTemp.Length == range)
                    {
                        binaryWholeContainer.Add(binaryTemp);
                        break;
                    }
                    binaryTemp = sign + binaryTemp;
                }
            }

            string octalHexWhole = "";
            foreach (string i in binaryWholeContainer)
            {
                double y = binary_decimal.binary_to_decimal(i);
                string convert = splitter.hexa_replacer((decimal)y);
                octalHexWhole = convert + octalHexWhole;
            }
            //-----Fraction----
            var binaryFractionContainer = new List<string>() { };
            binaryTemp = "";

            foreach (var i in binaryFraction)
            {
                if (binaryTemp.Length == range)
                {
                    binaryFractionContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp += i;
            }

            if (String.IsNullOrEmpty(binaryTemp) != true)
            {
                for (int i = 0; i <= range; i++)
                {
                    if (binaryTemp.Length == range)
                    {
                        binaryFractionContainer.Add(binaryTemp);
                        break;
                    }
                    binaryTemp += sign;
                }
            }

            string octalHexFraction = ".";
            foreach (var i in binaryFractionContainer)
            {
                double x = binary_decimal.binary_to_decimal(i);
                string convetx = splitter.hexa_replacer((decimal)x);
                octalHexFraction += convetx.ToString();
            }

            return octalHexWhole + octalHexFraction;

        }

        public string octalhex_to_Bin(string value, int range)
        {
            var (whole, fraction) = splitter.hexa_splitter(value);
            string binaryWholeContainer = "";

            for (int i = 0; i <= whole.Count - 1; i++)
            {
                int number = Convert.ToInt32(whole[i]);
                string wholeTemp = "";
                for (int j = 0; j < range; j++)
                {
                    decimal binary = Convert.ToDecimal(number) % 2;
                    wholeTemp = binary.ToString() + wholeTemp;
                    number /= 2;
                }

                binaryWholeContainer += wholeTemp;
            }


            string binaryFractionContainer = ".";

            for (int i = 0; i <= fraction.Count - 1; i++)
            {
                int number = Convert.ToInt32(fraction[i]);
                string fractionTemp = "";
                for (int j = 0; j < range; j++)
                {
                    decimal binary = Convert.ToDecimal(number) % 2;
                    fractionTemp = binary.ToString() + fractionTemp;
                    number /= 2;
                }

                binaryFractionContainer += fractionTemp;
            }

            return binaryWholeContainer + binaryFractionContainer;


        }
    }
}
