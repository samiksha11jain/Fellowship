using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprogram
{
     class Replaceword
    {
        public static void ReadingInputFromUser()
        {
            Console.WriteLine("please enter your username");
            string name = Console.ReadLine();
            if(name.Length>=3)
            {
                ReplaceStringWithTemplate(name);
            }
            else
            {
                Console.WriteLine("please provide your username alteast");
            }

        }
        public static void ReplaceStringWithTemplate(string name)
        {
            string template = "Replace <<username>> with the proper name";
            if  (template.Contains("<<username>>"))
            {
                string result = template.Replace("<<username>>", name);
                Console.WriteLine("arter replace:"+result);
            }
            else
            {
                Console.WriteLine("usre name not exit");
            }
        }

    }
}
