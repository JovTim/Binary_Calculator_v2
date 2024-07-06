using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using program_splitter;

namespace binary_and_decimal
{
    internal class binary_decimal
    {
        splitter splitter = new splitter(); // public object
        public double binary_to_decimal(string value)
        {
            
            var (binary1, binary2) = splitter.bin_splitter(value);

            double whole = 0;
            double fraction = 0;
            if (String.IsNullOrEmpty(binary1) != true) 
            {
                double a = 0;
                for (int i = binary1.Length - 1; i >= 0; i--)
                {
                    whole += Convert.ToDouble(Convert.ToString(binary1[i])) * Math.Pow(2, a);
                    a++;
                }
            }
            if (String.IsNullOrEmpty(binary2) != true) 
            {
                double b = 1;
                for (int i = 0; i <= binary2.Length - 1; i++)
                {
                    fraction += Convert.ToDouble(Convert.ToString(binary2[i])) * Math.Pow(2, (-b));
                    b++;
                }
            }

            return whole + fraction;

        }

        public string decimal_to_binary(string value)
        {
            var (whole, fraction) = splitter.deci_splitter(value);

            var whole_container = new List<decimal>() { };
            whole_container.Add(whole);
            while (whole >= 2)
            {
                whole /= 2;
                whole_container.Add((int)whole);
            }

            string remainder = "";

            for (int i = whole_container.Count - 1; i >= 0; i--)
            {
                decimal x = (decimal)whole_container[i] % 2;
                remainder += x.ToString();
            }

            if (fraction == 0) // check to include fraction or not
            {
                return remainder;
            }

            var fraction_container = new List<decimal>() { };

            // Most floating-point values can't be precisely represented as a finite binary value
            // I set the range to 8
            // You can adjust the range of the floating-point for binary
            for (int i = 0; i <= 8; i++)
            {
                decimal number = (decimal)fraction * 2;
                string word = Convert.ToString(number);
                fraction_container.Add(Convert.ToDecimal(word[0].ToString()));
                double s = Convert.ToDouble(word) - Convert.ToDouble(fraction_container[i]);
                fraction = s;
            }

            string last = "0.";

            foreach(decimal ch in fraction_container)
            {
                last += ch.ToString();
            }

            var output = Convert.ToDecimal(remainder) + Convert.ToDecimal(last);

            return output.ToString();
        }
        static void Run(string[] args)
        {
            
        }
    }
}
