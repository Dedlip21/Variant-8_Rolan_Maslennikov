using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontroltoo1_Rolan_Maslennikov
{
    public class Alamprogram
    {
        public static void Min()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);
            int minNum;

            int[] rndNums = new int[2] { num1, num2 };

            Console.WriteLine("Number 1 - " + num1);
            Console.WriteLine("Number 2 - " + num2);

            if (rndNums[0] < rndNums[1])
            {
                minNum = num1;
                Console.WriteLine("Minimum number is - " + minNum);
            }
            else if (rndNums[0] > rndNums[1])
            {
                minNum = num2;
                Console.WriteLine("Minimum number is - " + minNum);
            }
            else
            {
                Console.WriteLine("Numbers are the same. But that's 1% chance so this is lucky try.");
            }
            Console.ReadKey();
        }
        public static void Max()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int maxNum;

            int[] rndNums = new int[2] { num1, num2 };

            Console.WriteLine("Number 1 - " + rndNums[0]);
            Console.WriteLine("Number 2 - " + rndNums[1]);

            if (rndNums[0] > rndNums[1])
            {
                maxNum = num1;
                Console.WriteLine("Maximum number is - " + maxNum);
            }
            else if (rndNums[0] < rndNums[1])
            {
                maxNum = num2;
                Console.WriteLine("Maximum number is - " + maxNum);
            }
            else
            {
                Console.WriteLine("Numbers are the same. But that's 1% chance so this is lucky try.");
            }
        }
        public static void lastName()
        {
            string[] lnames = new string[3];
            /*Console.WriteLine("First last name");
            string ln1 = Console.ReadLine();
            Console.WriteLine("Second last name");
            string ln2 = Console.ReadLine();
            Console.WriteLine("Third last name");
            string ln3 = Console.ReadLine();*/
            for (int m = 0; m < 3; m++)
            {
                Console.WriteLine("Type your last name ");
                string ln = Console.ReadLine();
                lnames[m] = ln;
            }
            foreach (var l in lnames)
            {
                Console.WriteLine("Tere, {0} ", l);
            }

            /*int m = 0;

            do
            {
                m++;
                Console.WriteLine("Type your last name ");
                string ln = Console.ReadLine();

            } while (m != 3);*/


            int maxLen = lnames[0].Length, indexMax = 0;

            for (int i = 0; i < lnames.Length; i++)
            {
                if (lnames[i].Length > maxLen)
                {
                    maxLen = lnames[i].Length;
                    indexMax = i;
                }

            }
            Console.WriteLine("The longest last name is " + lnames[indexMax]);
        }
        public static void splitWord()
        {
            Console.WriteLine("Insert your name ");

            string str = Console.ReadLine();

            int vowels = 0;
            int consonant = 0;

            foreach (char c in str)
            {
                char[] letters = new char[] { c };
                Console.WriteLine(letters);
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == 'a' || letters[i] == 'e' || letters[i] == 'i' || letters[i] == 'o' || letters[i] == 'u')
                    {
                        vowels++;
                    }
                    else
                    {
                        consonant++;
                    }
                }
            }

            /*for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonant++;
                }
            }*/

            Console.WriteLine("Your total number of vowels is: {0}", vowels);
            Console.WriteLine("Your total number of constant is: {0}", consonant);
        }
    }
}
