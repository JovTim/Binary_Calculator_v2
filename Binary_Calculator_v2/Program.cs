using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binary_and_decimal;
using binary_hexa;
using binary_octal;

namespace Binary_Calculator_v2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            binary_decimal binary_Decimal = new binary_decimal();
            hexa_and_binary hexa_And_Binary = new hexa_and_binary();
            octal_and_binary octal_And_Binary = new octal_and_binary();


            //Console.WriteLine(binary_Decimal.decimal_to_binary("75"));
            //Console.WriteLine(hexa_And_Binary.binary_to_hexa("01111010111.101"));
            //Console.WriteLine(hexa_And_Binary.hexa_to_binary("1C.4A"));
            //Console.WriteLine(binary_Decimal.binary_to_decimal("1011"));
            Console.WriteLine(octal_And_Binary.binary_to_octal("01110111.1101"));
            
        }
    }
}
