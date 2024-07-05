using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using binary_and_decimal;
using twos_complement_file;
namespace program_splitter
{
    internal class splitter
    {
        public (string, string) bin_splitter(string value)
        {
            if (value.Contains(".")) {
                var binary = new List<string>(value.Split('.'));
                string whole = binary[0];
                string fraction = binary[1];

                return (whole, fraction);
            }
            else
            {
                var binary = new List<string>(value.Split('.'));
                string whole = binary[0];
                string fraction = "";

                return (whole, fraction);

            }
        }

        public (decimal, double) deci_splitter(string value)
        {
            if (value.Contains(".")) 
            {
                var deci = new List<string>(value.Split('.'));
                string whole = deci[0];
                string fraction = "0." + deci[1];

                return (Convert.ToDecimal(whole), Convert.ToDouble(fraction));
            }
            else
            {
                var deci = new List<string>(value.Split('.'));

                string whole = deci[0];
                double fraction = 0;

                return (Convert.ToDecimal(whole), fraction);
            }
        }

        public string hexa_replacer(decimal value)
        {
            Dictionary<decimal, string> hexadecimal = new Dictionary<decimal, string> 
            {
                {10, "A" },
                {11, "B" },
                {12, "C" },
                {13, "D" },
                {14, "E" },
                {15, "F" }
            };

            if (hexadecimal.ContainsKey(value))
            {
                return hexadecimal[value];
            }
            else
            {
                return value.ToString();
            }
        }

        public (List<string>, List<string>) hexa_splitter(string value)
        {
            Dictionary<string, decimal> hexadecimal = new Dictionary<string, decimal>
            {
                {"A", 10 },
                {"B", 11 },
                {"C", 12 },
                {"D", 13 },
                {"E", 14 },
                {"F", 15 }
            };
            var whole_container = new List<string>() { };
            var fraction_container = new List<string>() { };
            var hexa = new List<string>(value.Split('.'));
                
            for (int i = 0; i <= hexa[0].Length - 1; i++)
            {
               if (hexadecimal.ContainsKey(hexa[0][i].ToString()))
                {
                    whole_container.Add(hexadecimal[hexa[0][i].ToString()].ToString());
                }
                else 
                {
                    whole_container.Add(hexa[0][i].ToString());
                }
                    
            }

            for (int i = 0; i <= hexa[1].Length - 1; i++) 
            { 
                if (hexadecimal.ContainsKey(hexa[1][i].ToString())) 
                {
                    fraction_container.Add(hexadecimal[hexa[1][i].ToString()].ToString());
                }
                else
                {
                    fraction_container.Add(hexa[1][i].ToString());
                }
            }

                return (whole_container, fraction_container);   

        }
        
        public string binPerform(string value)
        {
            binary_decimal binary_Decimal = new binary_decimal();
            twos_complement twos_Complement = new twos_complement();
            if (value[0] == '1')
            {
                double x = binary_Decimal.binary_to_decimal(twos_Complement.twosComplement(value));
                double z = 0 - x;
                return z.ToString();
            }
            return binary_Decimal.binary_to_decimal(value).ToString();
        }

        public string binDivisibleChecker(string value, string sign)
        {
            if (value.Contains("."))
            {
                var val = new List<string>(value.Split('.'));
                string binary = val[0];

                while (binary.Length % 4 != 0)
                {
                    binary = sign + binary;
                }
                return binary + "." + val[1];
            }

            while (value.Length % 4 != 0)
            {
                value = sign + value;
            }
            return value;
        }
        

        public string binCalFixer(string value)
        {
        binary_decimal binary_Decimal = new binary_decimal();
        twos_complement twos_Complement = new twos_complement();
            if (value[0] == '-')
            {
                string deci = "";
                foreach (var i in value)
                {
                    if (i == '-')
                    {
                        continue;
                    }
                    deci += i.ToString();

                }
                string x = binary_Decimal.decimal_to_binary(deci);
                string final = twos_Complement.twosComplement(x);
                return binDivisibleChecker(final, "1");
            }
            return binDivisibleChecker(binary_Decimal.decimal_to_binary(value), "0");
            //return binary_Decimal.decimal_to_binary(binDivisibleChecker(value, "0"));
        }
        

    }
}
