using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                   //create size of array
            string[] arr = Console.ReadLine().Split();               //create string array with elements
            int[] arr2 = new int[n];                                 //create new empty array for saving new elements
            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(arr[i]);                         //convert to int 
            }
            int[] d = new int[n * 2];                                //set new array
            for (int i = 0; i < arr2.Length; i++)
            {
                d[i * 2] = arr2[i];                                  //set number
                d[i * 2 + 1] = arr2[i];                              //make a copy of number
            }
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i] + " ");                           //print array 
            }
            Console.ReadKey();
        }
    }
}
