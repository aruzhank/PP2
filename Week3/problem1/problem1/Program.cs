using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    class FarManager                                                                    //создаем класс
    {
        int cursor;                                                                     //создаем курсор
        int number;                                                                     //создаем количество файлов и папок
        public FarManager()                                                             //конструктор
        {
            cursor = 0;                                                                 //курсор стоит на самой верхней строке               
        }
        public void Show(DirectoryInfo di, int index)                                   //создаем функцию
        {
            FileSystemInfo[] fi = di.GetFileSystemInfos();                              //создаем массив, чтобы получить инфо обо всем, что находится внутри
            for (int i = 0; i < fi.Length; i++)                                         //пробегаемся по файлам
            {
                if (index == i)                                                         //даем цвет
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(i + 1 + ". " + fi[i].Name);
                }
                else if (fi[i].GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + fi[i].Name);
                }
                else if (fi[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(i + 1 + ". " + fi[i].Name);
                }
            }
        }
        public void Start(string path)                                                  //создаем функцию
        {
            ConsoleKeyInfo button = Console.ReadKey();                                  //считываем кнопку
            while (button.Key != ConsoleKey.Escape)                                     //будет работать, пока не нажмем esc
            {
                DirectoryInfo dir = new DirectoryInfo(path);                            //создаем dir, чтобы сохранить там путь папки
                FileSystemInfo[] fsi = dir.GetFileSystemInfos();                        //создаем массив, чтобы получить инфо обо всем, что находится внутри
                number = fsi.Length;                                                    //количество приравняем к длине массива
                Show(dir, cursor);                                                      //вызываем метод
                button = Console.ReadKey();                                             //кнопка, где будут храниться клавиши
                Console.BackgroundColor = ConsoleColor.Black;                           //придаем черный фон
                Console.Clear();                                                        //очищаем
                if (button.Key == ConsoleKey.UpArrow)                                   //нажимаем клавишу вверх
                {
                    cursor--;
                    if (cursor < 0)
                    cursor = number - 1;
                }
                if (button.Key == ConsoleKey.DownArrow)                                 //нажимаем клавишу вниз
                {
                    cursor++;
                    if (cursor == number)
                    cursor = 0;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager far = new FarManager();                                          //присваеваем far значение FarManager
            far.Start(@"C:\Users\Acer\PP2");                                            //путь где будем все это делать
        }
    }
}
