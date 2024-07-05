using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binary_and_decimal;
using twos_complement_file;
using binOctalHexa;
using binary_calculation;
using Checker;

namespace Binary_Calculator_v2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            conversion converts = new conversion();

            // Console.WriteLine(converts.binaryDecimalChecker("01101")); // binary to decimal (whole) *check
            // Console.WriteLine(converts.decimalBinaryChecker("13")); // decimal to binary (whole) *check
            // Console.WriteLine(converts.binaryDecimalChecker("101011")); // binary to decimal (signed whole) *check
            // Console.WriteLine(converts.decimalBinaryChecker("-13")); // decimal to binary (signed whole) *check

            // Console.WriteLine(converts.binaryOctalChecker("0110111")); // binary to octal (whole) *check
            // Console.WriteLine(converts.octalBinaryChecker("067")); // octal to binart (whole) *check
            // Console.WriteLine(converts.binaryOctalChecker("10110111")); // binary to octal (signed whole) *check
            // Console.WriteLine(converts.octalBinaryChecker("7067")); // octal to binary (signed whole) *check

            //  Console.WriteLine(converts.binaryHexaChecker("0110101001")); // binary to hexa (whole) *check
            // Console.WriteLine(converts.hexaBinaryChecker("A97")); // hexa to binary (whole) *check
            // Console.WriteLine(converts.binaryHexaChecker("101101101")); // binary to hexa (signed whole) *check
            // Console.WriteLine(converts.hexaBinaryChecker("F1A")); // hexa to binary (signed whole) *check

        }
    }
}
