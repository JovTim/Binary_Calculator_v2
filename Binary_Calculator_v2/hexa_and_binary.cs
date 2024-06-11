using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_splitter;
using binary_and_decimal;
// Have not added if whole or fraction only. Might add later <11-06-24>
namespace binary_hexa
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
            foreach (string i in binaryWholeContainer)
            {
                double y = binary_decimal.binary_to_decimal(i);
                string convert = splitter.hexa_replacer((decimal)y);
                hexadecimalWhole = convert + hexadecimalWhole;
            }
            //-----Fraction----
            var binaryFractionContainer = new List<string>() { };
            binaryTemp = "";

            foreach (var i in binaryFraction)
            {
                if (binaryTemp.Length == 4)
                {
                    binaryFractionContainer.Add(binaryTemp);
                    binaryTemp = "";
                }
                binaryTemp += i;
            }

            if (String.IsNullOrEmpty(binaryTemp) != true)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (binaryTemp.Length == 4)
                    {
                        binaryFractionContainer.Add(binaryTemp);
                        break;
                    }
                    binaryTemp += "0";
                }
            }

            string hexadecimalFraction = ".";
            foreach (var i in binaryFractionContainer)
            {
                double x = binary_decimal.binary_to_decimal(i);
                string convetx = splitter.hexa_replacer((decimal)x);
                hexadecimalFraction += convetx.ToString();
            }

            return hexadecimalWhole + hexadecimalFraction;

        }

        public string hexa_to_binary(string value)
        {
            var (whole, fraction) = splitter.hexa_splitter(value);
            string binaryWholeContainer = "";

            for (int i = 0; i <= whole.Count - 1; i++)
            {
                int number = Convert.ToInt32(whole[i]);
                string wholeTemp = "";
                for (int j = 0; j < 4; j++)
                {
                    decimal binary = Convert.ToDecimal(number) % 2;
                    wholeTemp = binary.ToString() + wholeTemp;
                    number /= 2;
                }

                binaryWholeContainer = wholeTemp + binaryWholeContainer;
            }


            string binaryFractionContainer = ".";

            for (int i = 0; i <= fraction.Count - 1; i++)
            {
                int number = Convert.ToInt32(fraction[i]);
                string fractionTemp = "";
                for (int j = 0; j < 4; j++)
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
