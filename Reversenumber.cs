using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprogram
{
    class Reversenumber
    {
        public int numb = 2;
        public static int first = 0;

        public void FindReverse()
        {
            Console.WriteLine("enter a no. to revers");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            Console.WriteLine(numb);
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
        }
    }
}
