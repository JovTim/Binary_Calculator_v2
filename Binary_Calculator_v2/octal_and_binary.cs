using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_splitter;
using binary_and_decimal;

// this file is temporary
// both octal and hexa have the same code structure, but different length octal(000), hexa(0000)
// will make a way to merge both octal and hexa conversion into one code file
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

        public string octal_to_binary(string value)
        {
            var (whole, fraction) = splitter.bin_splitter(value);
            string binaryWholeContainer = "";

            for (int i = 0; i <= whole.Length - 1; i++)
            {
                int number = Convert.ToInt32(whole[i]);
                string wholeTemp = "";
                for(int j = 0; j < 3; j++)
                {
                    decimal binary = Convert.ToDecimal(number) % 2;
                    wholeTemp = binary.ToString() + wholeTemp;
                    number /= 2;
                }

                binaryWholeContainer += wholeTemp;
            }

            string binaryFractionContainer = ".";

            for (int i = 0; i <= fraction.Length - 1; i++)
            {
                int number = Convert.ToInt32(fraction[i]);
                string fractionTemp = "";
                for (int j = 0; j < 3; j++)
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
