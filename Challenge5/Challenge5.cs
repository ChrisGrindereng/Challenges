using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizBuzz
{
    class FizzBuzzChallenge
    {
        static int[] numbers = new int[100];

        static void Main(string[] args)
        {
            for (int i = 0; i <= 99; i++)

            {

                 numbers[i] = i + 1;
                if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
                {
                    Console.WriteLine("FizBuzz");
                }
                else if(numbers[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (numbers[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(numbers[i]);
                }
             }
        Console.ReadLine();

        }
        
    }
}
