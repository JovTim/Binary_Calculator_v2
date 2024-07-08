using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_splitter;
using Checker;

namespace binary_calculation
{
    internal class calculation
    {
        
        splitter splitter = new splitter();


        public string binAddition(string bin1, string bin2)
        {
            try
            {
                string value1 = splitter.binPerform(bin1);
                string value2 = splitter.binPerform(bin2);

                double calculate = (Convert.ToDouble(value1) + Convert.ToDouble(value2));

                return splitter.binCalFixer(calculate.ToString());
            }
            catch (Exception e)
            {
                return "Value Error";
            }
        }

        public string binSubtraction(string bin1, string bin2)
        {
            try
            {
                string value1 = splitter.binPerform(bin1);
                string value2 = splitter.binPerform(bin2);

                double calculate = (Convert.ToDouble(value1) - Convert.ToDouble(value2));

                return splitter.binCalFixer(calculate.ToString());
            }
            catch (Exception e)
            {
                return "Value Error";
            }
        }

        public string binMultiplication(string bin1, string bin2)
        {
            try
            {
                string value1 = splitter.binPerform(bin1);
                string value2 = splitter.binPerform(bin2);

                double calculate = (Convert.ToDouble(value1) * Convert.ToDouble(value2));

                return splitter.binCalFixer(calculate.ToString());
            }
            catch(Exception e)
            {
                return "Value Error";
            }
            
        }

        public string binDivision(string  bin1, string bin2)
        {
            try
            {
                string value1 = splitter.binPerform(bin1);
                string value2 = splitter.binPerform(bin2);

                double calculate = (Convert.ToDouble(value1) / Convert.ToDouble(value2));

                return splitter.binCalFixer(calculate.ToString());
            }
            catch( Exception e)
            {
                return "Value Error";
            }
            
        }
        
    }
}
