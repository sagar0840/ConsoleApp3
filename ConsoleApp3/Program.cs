using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Write a C# program to find total number of alphabets, digits or special character in a string.

    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alp, digit, splch, i, l;
            alp = digit = splch = i = 0;


            Console.Write("Count total number of alphabets, digits and special characters ");
            Console.Write("--------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            l = str.Length;


            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splch++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}", alp);
            Console.Write("Number of Digits in the string is : {0}", digit);
            Console.Write("Number of Special characters in the string is : {0}\n", splch);
        }
    }
}
    

