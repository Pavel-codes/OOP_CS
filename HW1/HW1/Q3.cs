using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            const int cols = 3;
            int rowCount = 0, index = 0;
            int[] arr = new int[] { -1, 0, 1, 2, -1, 4, -3, -4, 2 };
            for (int i = 0; i < arr.Length-2; i++)
            {
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    for (int k = j+1; k < arr.Length; k++)
                    {
                        if(arr[i] + arr[j] + arr[k] == 0 && i != j && i != k && j != k)
                        {
                            rowCount++;
                        }
                    }
                }
            }
            int[,] newArr = new int[rowCount, cols];
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0 && i != j && i != k && j != k)
                        {
                            newArr[index, 0] = arr[i];
                            newArr[index, 1] = arr[j];
                            newArr[index, 2] = arr[k];
                            index++;
                        }
                    }
                }
            }
            for (int i = 0; i < newArr.GetLength(0); i++)
            {
                for (int j = 0; j < newArr.GetLength(1); j++)
                {
                    Console.Write($"{newArr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
