using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// two's complement code is based from geeksforgeeks
// https://www.geeksforgeeks.org/1s-2s-complement-binary-number/
// However, I modified the code to accept decimal point
namespace twos_complement_file
{
    internal class twos_complement
    {
        private static (int, string) pointCounter(string value)
        {
            int index = 0;
            string binary = "";

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '.')
                {
                    index += value.IndexOf('.');
                    continue;
                }

                binary += value[i];
            }

            return (index, binary);

        }

        private static char flip(char c)
        {
            return (c == '0') ? '1' : '0';
        }

        public string twosComplement(string value) // only focus on fraction
        {
            var (counter, binary) = pointCounter(value);
            String ones = "", twos = "";
            ones = twos = "";

            int i;

            for (i = 0; i < binary.Length; i++)
            {
                ones += flip(binary[i]);
            }

            twos = ones;

            for (i = binary.Length - 1; i >= 0; i--)
            {
                if (ones[i] == '1')
                {
                    twos = twos.Substring(0, i) + '0' + twos.Substring(i + 1, twos.Length - (i + 1));
                }
                else
                {
                    twos = twos.Substring(0, i) + '1' + twos.Substring(i + 1, twos.Length - (i + 1));
                    break;
                }
                
            }

            if (i == -1)
            {
                twos = '1' + twos;
            }

            if (counter > 0)
            {
                string pointTwosCompelementBinary = twos.Insert(counter, ".");
                return pointTwosCompelementBinary;
            }

            return twos;
        }

    }
}
