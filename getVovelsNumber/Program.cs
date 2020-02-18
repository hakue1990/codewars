using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Return the number (count) of vowels in the given string.

//We will consider a, e, i, o, and u as vowels for this Kata.

//The input string will only consist of lower case letters and/or spaces.

namespace vovelsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            GetVovelCount("eease");
            Console.ReadKey();
        }
        public static void GetVovelCount(string str)
        {
            Console.WriteLine(str.Count(i => "eaoie".Contains(i)));
            
        }
    }
}
