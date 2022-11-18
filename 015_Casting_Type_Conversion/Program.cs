using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Casting_Type_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNum = 100;
            string strNum = "";

            //Int to a string
            strNum = intNum.ToString();
            Console.WriteLine("String Number (int) = " + strNum);



            //Float to a string
            float floatNum = 3.9f;

            strNum = floatNum.ToString();
            Console.WriteLine("String Number (flt) = " + strNum);




            //Float to an int (Round Up or Round Down)
            floatNum = 3.3f;
            intNum = Convert.ToInt32(floatNum);
            Console.WriteLine("Float: " + floatNum.ToString() + " converted to int (Round Down): " + intNum.ToString());

            floatNum = 3.9f;
            intNum = Convert.ToInt32(floatNum);
            Console.WriteLine("Float: " + floatNum.ToString() + " converted to int (Round Up): " + intNum.ToString());




            //Float to an int (no rounding... just decimal removal)
            floatNum = 3.3f;
            intNum = (int)floatNum;
            Console.WriteLine("Float: " + floatNum.ToString() + " converted to int (No Rounding): " + intNum.ToString());

            floatNum = 3.9f;
            intNum = (int)floatNum;
            Console.WriteLine("Float: " + floatNum.ToString() + " converted to int (No Rounding): " + intNum.ToString());

        }
    }
}
