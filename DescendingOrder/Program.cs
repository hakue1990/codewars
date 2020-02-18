using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

//Examples: Input: 21445 Output: 54421

//Input: 145263 Output: 654321

//Input: 123456789 Output: 987654321

namespace Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            DesscendingOrder(123456);
                Console.ReadKey();
        }
        public static void DesscendingOrder(int num)
        {
            char[] array = num.ToString().ToCharArray();
            Array.Reverse(array);
            int newSort = Convert.ToInt32(new string(array));
            Console.WriteLine(newSort);
        }
    }
}
