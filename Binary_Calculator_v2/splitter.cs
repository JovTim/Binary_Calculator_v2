using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

    }
}
