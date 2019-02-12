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
        static bool isPrime(int n)                      //пишем функцию для проверки простых чисел
        {
            bool pr = true;
            if (n < 2)
            {
                pr = false;
            }
            for(int i=2; i*i<=n; i++)
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
            StreamReader st = new StreamReader(@"C:\Users\Acer\PP2\task2\task2\input.txt");               //открываем файл
            string[] s = st.ReadToEnd().Split();                                                          //читаем содержимое
            StreamWriter sw = new StreamWriter(@"C:\Users\Acer\PP2\task2\task2\output.txt");              //указываем файл, куда нужно написать простые числа
            int[] arr = new int[s.Length];                                                                //создаем новый массив для хранения простых чисел
            for(int i=0; i<s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);                                                                 //конвертируем массив в int
 
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (isPrime(arr[i]) == true)                                                             //если функция правильная
                {
                    sw.Write(arr[i] + " ");                                                              //выводим простые числа в другом файле
                }
            }

            sw.Close();                                                                                 //закрываем файл

            Console.ReadKey();
        }
    }
}
