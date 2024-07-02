using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binary_and_decimal;
using twos_complement_file;
using binOctalHexa;
using binary_calculation;

namespace Binary_Calculator_v2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            binary_decimal binary_Decimal = new binary_decimal();
            twos_complement twos_Complement = new twos_complement();
            bin_octal_hexa bin_Octal_Hexa = new bin_octal_hexa();
            calculation calculation = new calculation();


            //Console.WriteLine(binary_Decimal.decimal_to_binary("75"));
            //Console.WriteLine(hexa_And_Binary.binary_to_hexa("01111010111.101"));
            //Console.WriteLine(hexa_And_Binary.hexa_to_binary("1C.4A"));
            //Console.WriteLine(binary_Decimal.binary_to_decimal("1011"));
            //  Console.WriteLine(octal_And_Binary.octal_to_binary("715.34"));

            //Console.WriteLine(bin_Octal_Hexa.octalhex_to_Bin("BEEF.5A", 4));

            Console.WriteLine(calculation.binAddition("10111.011", "01.110"));

            // Console.WriteLine(twos_Complement.twosComplement("0110.11"));
            
        }
    }
}
