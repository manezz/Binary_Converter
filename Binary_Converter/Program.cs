using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = number;

            List<string> num = new List<string>();

            int conv = 1;
            while (number >= conv)
            {
                number -= conv;
                conv += conv;
            }
            while (conv != 0)
            {
                if (number2 - conv >= 0)
                {
                    num.Add("1");
                    number2 -= conv;
                    if (conv == 1) { conv -= 1; }
                    else { conv /= 2; }
                }
                else
                {
                    num.Add("0");
                    if (conv == 1) { conv -= 1; }
                    else { conv /= 2; }
                }
            }
            num.ForEach(i => Console.Write(i));

            Console.ReadLine();
        }
    }
}
