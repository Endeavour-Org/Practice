using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetChekc
{
    public static class Program
    {
        public static void Main()
        {
            {

                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

                int sum = 0;

                for (int i = 0; i < n; i++)
                {

                    sum += arr[i];
                };
                Console.Write(sum);
                Console.ReadLine();
            }
        }
    }
}
  
