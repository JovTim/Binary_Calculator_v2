using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using binary_and_decimal;

namespace Binary_Calculator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Search How to Convert string number into decimal
            // Search How to return list from method
            /*
            string binary = "1011.11";
            var whole = new List<decimal>() { };

            foreach(char c in binary)
            {
                if (c == '.')
                {
                    break;
                }
                whole.Add(Convert.ToDecimal(c.ToString()));
            }

            foreach (var a in whole)
            {
                Console.Write(a);
            }
            */
            binary_decimal binary_Decimal = new binary_decimal();

            //Console.WriteLine(binary_Decimal.decimal_to_binary("75.10"));

            Console.WriteLine(binary_Decimal.binary_to_decimal("1001011.00011001100"));
            
        }
    }
}
