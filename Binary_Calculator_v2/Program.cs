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
            Console.WriteLine(converts.decimalBinaryChecker("-13"));

        }
    }
}
