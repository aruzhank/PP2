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
            StreamReader st = new StreamReader(@"C:\Users\Acer\PP2\task1\text.txt");        //открыть файл, который нужно прочесть
            string s = st.ReadToEnd();                                                      //прочитать строку в файле
            bool pal = true;                                                                //создать переменную bool
            for(int i=0; i<s.Length; i++)
            {
                if (s[s.Length - 1 - i] != s[i])                                            //проверить строку, если индексы не совпадают, то выйти из цикла 
                {
                    pal = false;
                }
               
            }
                if (pal)
                {
                    Console.WriteLine("Yes");                                              //если палиндром, вывести "да"
                }
                else
                {
                    Console.WriteLine("No");                                               //если не палиндром, вывести "нет" 
                }
            Console.ReadKey();
        }
    }
}
