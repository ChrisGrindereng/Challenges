using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
           
public class Addition
        {

        static Func<int, int, int> sum = (a, b) => (a + b);


        public static void Main()
            {
            
            Console.WriteLine(sum(1, 2) == 3);
            Console.ReadLine();
            }
        }


    }

