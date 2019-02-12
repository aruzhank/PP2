 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static bool isPrime(int n)
        {
            bool pr = true;
            if (n < 2)
            {
                pr = false;
            }
            for(int i=2; i<n; i++)
            {
                if (n % i == 0)
                {
                    pr = false;
                }
            }
            return pr;
        }
        static void Main(string[] args)
        {
            StreamReader st = new StreamReader(@"C:\Users\Acer\PP2\task2\task2\input.txt");
            string[] s = st.ReadToEnd().Split();
            StreamWriter sw = new StreamWriter(@"C:\Users\Acer\PP2\task2\task2\output.txt");
            int[] arr = new int[s.Length];
            for(int i=0; i<s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
 
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (isPrime(arr[i]) == true)
                {
                    sw.Write(arr[i] + " ");
                }
            }

            sw.Close();

            Console.ReadKey();
        }
    }
}
