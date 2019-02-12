using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader st = new StreamReader(@"C:\Users\Acer\PP2\task1\text.txt");
            string s = st.ReadToEnd();
            bool pal = true;
            for(int i=0; i<s.Length; i++)
            {
                if (s[s.Length - 1 - i] != s[i])
                {
                    pal = false;
                }
               
            }
                if (pal)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            Console.ReadKey();
        }
    }
}
