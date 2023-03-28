using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            const int size = 9;
            int[] arr = new int[size];
            int[] arr2 = new int[size];
            Console.WriteLine("Please enter 9 numbers between 0 - 100:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0 || arr[i] > 100)
                {
                    Console.WriteLine("Please re-enter a number between 0 and 100");
                    i--;
                }
            }
            arr2 = arr.Distinct().ToArray();
            Console.Write("[ ");
            for (int i = 0; i < arr2.Length; i++)
            {
                if (i == arr2.Length-1)
                {
                    Console.Write(arr2[i] + " ");
                }
                else
                {
                    Console.Write(arr2[i] + ", ");
                }
            }
            Console.Write("]");
        }
    }
}
