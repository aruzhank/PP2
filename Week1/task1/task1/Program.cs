using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool isPrime(int n)                   //write function in order to check prime numbers           
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());               //create size of array
            string[] arr = Console.ReadLine().Split();           //create array and write elements with empty space
            int[] arr2 = new int[n];                             //create new empty array for prime numbers
            int cnt = 0;                                         //creating counter and making it equal to 0
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = int.Parse(arr[i]);                       //convert to int
                if (isPrime(arr2[i]) == true)                      //check whether given element is prime or not          
                {
                    cnt++;                                       //if it is true increasing counter
                }
            }
            Console.WriteLine(cnt);                             //display counter in console
            for (int i = 0; i < n; i++)
            {
                if (isPrime(arr2[i]))                            //if elements are prime 
                    Console.Write(arr2[i] + " ");                   //display elements that are prime numbers
            }
            Console.ReadKey();                                  //helps console to stay open and waits to press any key
        }
    }
}
