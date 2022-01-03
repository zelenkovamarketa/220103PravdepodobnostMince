using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int percent = 0;
            Random ran = new Random(); //ran.Next(0, 2)
            for (int i = 0; i < 10001; i++)
            {
                int[] arr = new int[100];
                for (int j = 0; j < 100; j++)
                {
                    arr[j] = ran.Next(2);
                }
                for (int k = 0; k < 94; k++)
                {
                    if (arr[k+1] == arr[k] && arr[k + 2] == arr[k] && arr[k + 3] == arr[k] && arr[k + 4] == arr[k] && arr[k + 5] == arr[k] && arr[k + 6] == arr[k])
                    {
                        percent++;
                        break;
                    }
                }
            }
            Console.WriteLine((double)percent/100 + "%");
            Console.ReadLine();
        }
    }
}
