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

            //Console.WriteLine(converts.binaryDecimalChecker("101.011"));
            //Console.WriteLine(converts.decimalBinaryChecker("-2.125"));

            //Console.WriteLine(converts.binaryOctalChecker("0101101.1011"))
            //Console.WriteLine(converts.octalBinaryChecker("0751.22"));

            Console.WriteLine(converts.hexaBinaryChecker("BE3F.3"));
        }
    }
}
