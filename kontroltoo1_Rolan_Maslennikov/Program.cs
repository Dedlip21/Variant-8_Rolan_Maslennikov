using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace kontroltoo1_Rolan_Maslennikov
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Say 1 to see random maximum number\nSay 2 to see random minimum number");
            Console.WriteLine("Say 3 to insert see the most longest last name that you write\nSay 4 to insert name, split it on every letter and find");
            

            int ch = int.Parse(Console.ReadLine());
            */

            string maximum = "maximum";
            string minimum = "minimum";
            string lastname = "lastname";
            string splitword = "splitletter";

            Console.WriteLine("Say 'maximum' to see random maximum number\nSay 'minimum' to see random minimum number");
            Console.WriteLine("Say 'lastname' to insert see the most longest last name that you write\nSay 'splitletter' to insert name, split it on every letter and find");
            string word = Console.ReadLine();

            if (word == maximum)
            {
                Alamprogram.Max();
            }

            else if (word == minimum)
            {
                Alamprogram.Min();
            }

            else if (word == lastname)
            {
                Alamprogram.lastName();
            }

            else if (word == splitword)
            {
                Alamprogram.splitWord();
            }

            /*
            switch (ch)
            {
                case 1:
                    Alamprogram.Max();
                    break;
                case 2:
                    Alamprogram.Min();
                    break;
                case 3:
                    Alamprogram.lastName();
                    break;
                case 4:
                    Alamprogram.splitLetter();
                    break;
            }
            Console.WriteLine(" ");
            */


            Console.ReadLine();
        }
    }
}
