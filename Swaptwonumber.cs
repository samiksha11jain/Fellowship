using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprogram
{
    public class Swaptwonumber
    {
        //static method for reading from user
        //static v
        public static void ReadingInputFromUser()
        {
            Console.WriteLine("please enter first number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second numner");
            int second=Convert.ToInt32(Console.ReadLine());
            //className variableName=new className();
            Swaptwonumber swap = new Swaptwonumber();
            swap.Swapnumber(first, second)
        }
        public void Swapnumber(int first,int second)
        {
            int temp = 0;
            Console.WriteLine("before swaping: first={0} second={1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("after sawaping: first={0} second={1}", first, second);
        }
    }

}
