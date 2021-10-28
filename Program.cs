using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N = Convert.ToInt32(Console.ReadLine());
            int[] digits = new int[N];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = Convert.ToInt32(Console.ReadLine());

            }

            int minDigit = Array.FindLast(digits, element => element < 0);
            int index = Array.FindLastIndex(digits,element => element == minDigit);
            Console.WriteLine(minDigit);
            Console.WriteLine(index);
            Console.ReadKey();

        }
    }
}
        
    
