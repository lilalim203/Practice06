/*  Develop a sub-algorithm with a parameter x of type number that returns if the number is prime or not, then use this sub-algorithm in the main program.
	- Example: given 2 => true
	- Example: given 7 => true
	- Example: given 20 => false */

using System;
using System.Collections.Generic;

class Program6
{
    private void isPrime(int input_num)
    {
        string isYN = " NOT";
        int count = 0;

        if (input_num > 0)
        {
            for (int divider = 1; divider <= input_num; divider++)
            {
                if (input_num % divider == 0) { count++; }
            }

            if (count == 2) { isYN = ""; }

            Console.WriteLine("\n->" + input_num + " IS" + isYN + " A PRIME NUMBER!\n");
        }
    }

    static void Main(string[] args)
    {
        Program6 p = new Program6();

        string sinput;
        int input=0;

        while (input != -1)
        {
            Console.Write("INPUT A NUMBER : ");
            sinput = Console.ReadLine();
            input = Convert.ToInt32(sinput);
            p.isPrime(input);
        }
    }
}
