using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
