using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binary_and_decimal;
using twos_complement_file;
using program_splitter;
using binOctalHexa;
using System.Security.Policy;

namespace Checker
{
    internal class conversion
    {
        binary_decimal binary_Decimal = new binary_decimal();
        twos_complement twos_Complement = new twos_complement();
        splitter splitter = new splitter(); 
        bin_octal_hexa binOctHex = new bin_octal_hexa();
        public bool binaryValueChecker(string value)
        {
            foreach (var i in value)
            {
                if (i.Equals('.'))
                {
                    continue;
                }
                if (Convert.ToDecimal(i.ToString()) > 1)
                {
                    return false;
                }
            }
            return true;
        }

        private bool octalValueChecker(string value)
        {
            foreach (var i in value)
            {
                if (i.Equals('.'))
                {
                    continue;
                }
                if (Convert.ToDecimal(i.ToString()) > 7 || i.Equals('-'))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ifDecimal(string value)
        {
            decimal number;
            if (decimal.TryParse(value, out number))
            {
                return true;
            }
            return false;
        }

        private bool ifIntegerOrHexa(string value)
        {
            Dictionary<string, int> hexadecimalValueChecker = new Dictionary<string, int>
            {
                { "A", 10 },
                { "B" , 11 },
                { "C" , 12 },
                { "D" , 13 },
                { "E" , 14 },
                { "F" , 15 },
            };
            decimal number;
            if (decimal.TryParse(value, out number)) // check if a string can be converted into decimal. If not, then it's a hex symbol
            {
                if (Convert.ToDecimal(value) > 9)
                {
                    return false;
                }
                return true;
            }

            if (hexadecimalValueChecker.ContainsKey(value) != true)
            {
                return false;
            }
            return true;
        }

        private bool hexaValueChecker(string value)
        {

            foreach (var i in value)
            {
                if (i.Equals('.'))
                {
                    continue;
                }
                if (ifIntegerOrHexa(i.ToString()) != true)
                {
                    return false;
                }
                
            }
            return true;

        }

        public string binarySignedChecker(string value, bool sign)
        {
            if (sign)
            {
                if (value[0].Equals('0'))
                {
                    return "1111" + value;
                }
                return value;
            }
            if (value[0].Equals('1'))
            {
                return "0000" + value;
            }
            return value;
        }

        private string hexaSignedChecker(string value)
        {
            if (value[0].Equals('F') != true)
            {
                return "F" + value;
            }
            return value;
        }

        private string octalSignedChecker(string value)
        {
            if (value[0].Equals('7') != true)
            {
                return "7" + value;
            }
            return value;
        }

        public string binaryDecimalChecker(string value)
        {
            if (binaryValueChecker(value) != true)
            {
                return "Value Error";
            }

            if (value[0].Equals('1'))
            {
                var binComplement = twos_Complement.twosComplement(value);
                var binDecimal = binary_Decimal.binary_to_decimal(binComplement);
                return (0 - binDecimal).ToString();

            }

            return (binary_Decimal.binary_to_decimal(value)).ToString();
        }

        public string decimalBinaryChecker(string value)
        {
            if (!ifDecimal(value))
            {
                return "Value Error";
            }
            if (Convert.ToDecimal(value) < 0)
            {
                var positiveDecimal = 0 - (Convert.ToDecimal(value));
                var convertToBinary = binary_Decimal.decimal_to_binary(positiveDecimal.ToString());
                return binarySignedChecker(splitter.binDivisibleChecker(twos_Complement.twosComplement(convertToBinary).ToString(), "1"), true);
            }

            return binarySignedChecker(splitter.binDivisibleChecker(binary_Decimal.decimal_to_binary(value), "0"), false);
        }

        public string binaryOctalChecker(string value)
        {
            if (binaryValueChecker(value) != true)
            {
                return "Value Error";
            }
            
            if (value[0].Equals ('1'))
            {
                var binary = splitter.binDivisibleChecker(value, "1");
                var octal = binOctHex.binary_to_OctalHexa(binary, 3, "1");
                return octalSignedChecker(octal);
            }

            var uOctal = binOctHex.binary_to_OctalHexa(value, 3, "0");
            return uOctal;
        }

        public string octalBinaryChecker(string value)
        {
            if (octalValueChecker(value) != true)
            {
                return "Value Error";
            }
            if (value[0].Equals('7'))
            {
                return splitter.binDivisibleChecker(binOctHex.octalhex_to_Bin(value, 3), "1");
            }
            return splitter.binDivisibleChecker(binOctHex.octalhex_to_Bin(value, 3), "0");
        }

        public string binaryHexaChecker(string value)
        {
            if (binaryValueChecker(value) != true)
            {
                return "Value Error";
            }

            if (value[0].Equals('1'))
            {
                var binary = splitter.binDivisibleChecker(value, "1");
                var hexa = binOctHex.binary_to_OctalHexa(binary, 4, "1");
                return hexaSignedChecker(hexa);
            }

            var uHexa = binOctHex.binary_to_OctalHexa(value, 4, "0");
            return uHexa;
        }
        public string hexaBinaryChecker(string value)
        {
            if (hexaValueChecker(value) != true)
            {
                return "Value Error";
            }

            if (value[0].Equals('F'))
            {
                return splitter.binDivisibleChecker(binOctHex.octalhex_to_Bin(value, 4), "1");
            }
            return splitter.binDivisibleChecker(binOctHex.octalhex_to_Bin(value, 4), "0");
        }
    }
}
