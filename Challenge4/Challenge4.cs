using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tweeter
{
    public class tweeterchallenge
    {
        static string tweeter(string text)
        {

            text = text.Replace("naps", "maps");
            return text;
        }
        public static void Main()
        {
            Console.WriteLine(tweeter("I really like naps") == "I really like maps");
            Console.WriteLine(tweeter("naps maps naps maps") == "maps maps maps maps");
            Console.ReadLine();

        }
    }
}
