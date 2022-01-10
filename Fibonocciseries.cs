using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprogram
{
    public class Fibonocciseries
    {
        //public int firstnum=0;
        //public int secondnum = 1;
        //public int result = 0;
        /// <summary>
        /// instances variables
        /// </summary>
        public int firstnum=0, secondnum=1, result=0;

        public void FindFibonocciseries()
        {
            Console.WriteLine("please enter number to generate series");
            //string num = Console.ReadLine();
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user number is: " + num);
            result = firstnum + secondnum;
            Console.Write("series are:" + firstnum + " " + secondnum);
            for(int i = 2; i < num;i++)
            {
                firstnum = secondnum;
                secondnum = result;
                Console.Write(" " + result);
                result = firstnum + secondnum;
            }
        }
    }
}
