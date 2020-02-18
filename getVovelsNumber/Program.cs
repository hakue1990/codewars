using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
