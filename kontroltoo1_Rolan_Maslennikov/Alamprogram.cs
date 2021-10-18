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

            Console.WriteLine("Number 1 - " + num1);
            Console.WriteLine("Number 2 - " + num2);

            if (num1 < num2)
            {
                minNum = num1;
                Console.WriteLine("Minimum number is - " + minNum);
            }
            else if (num1 > num2)
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

            Console.WriteLine("Number 1 - " + num1);
            Console.WriteLine("Number 2 - " + num2);

            if (num1 > num2)
            {
                maxNum = num1;
                Console.WriteLine("Maximum number is - " + maxNum);
            }
            else if (num1 < num2)
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
            Console.WriteLine("First last name");
            string ln1 = Console.ReadLine();
            Console.WriteLine("Second last name");
            string ln2 = Console.ReadLine();
            Console.WriteLine("Third last name");
            string ln3 = Console.ReadLine();

            string[] array = { ln1, ln2, ln3 };
            int maxLen = array[0].Length, indexMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxLen)
                {
                    maxLen = array[i].Length;
                    indexMax = i;
                }
         
            }
            Console.WriteLine("The longest last name is " + array[indexMax]);

        }
        public static void splitWord()
        {
            Console.WriteLine("Insert your name ");

            string str = Console.ReadLine();

            int vowels = 0;
            int consonant = 0;

            foreach (char c in str)
            {
                Console.WriteLine(c);
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonant++;
                }
            }

            Console.WriteLine("Your total number of vowels is: {0}", vowels);
            Console.WriteLine("Your total number of constant is: {0}", consonant);
        }
    }
}
