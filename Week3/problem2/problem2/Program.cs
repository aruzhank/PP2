using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
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
                    Console.BackgroundColor = ConsoleColor.Blue;
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
                if (button.Key == ConsoleKey.F2)                                        //нажимаем F2, чтобы переименовать файл 
                {
                    if (fsi[cursor].GetType() == typeof(FileInfo))                      //если это файл
                    {
                        string s = Console.ReadLine();                                  //то вводим имя
                        string ss = Path.Combine(dir.FullName, s);                      //соединяем имя с путем
                        File.Move(fsi[cursor].FullName, ss);                            //меняем название
                        Console.BackgroundColor = ConsoleColor.Black;                   //придаем черный фон, чтобы увидеть изменения
                        Console.Clear();                                                //очищаем
                    }
                    if (fsi[cursor].GetType() == typeof(DirectoryInfo))                 //если это папка
                    {
                        string s = Console.ReadLine();                                  //то вводим имя
                        string st = Path.Combine(dir.FullName, s);                      //соединяем имя с путем
                        Directory.Move(fsi[cursor].FullName, st);                       //меняем название            
                        Console.BackgroundColor = ConsoleColor.Black;                   //придаем черный фон, чтобы увидеть изменения
                        Console.Clear();                                                //очищаем
                    }
                }
                if (button.Key == ConsoleKey.Enter)                                     //нажимаем enter                                                  
                {
                    if (fsi[cursor].GetType() == typeof(FileInfo))                      //если это файл
                    {
                        StreamReader str = File.OpenText(fsi[cursor].FullName);         //открыть файл, где стоит курсор
                        string s = str.ReadToEnd();                                     //прочитать строку в файле
                        str.Close();                                                    //закрыть файл
                        Console.WriteLine(s);                                           //вывести на экран
                    }
                    if (fsi[cursor].GetType() == typeof(DirectoryInfo))                 //если это папка
                    {
                        path = fsi[cursor].FullName;                                    //то он открывает папку, где стоит курсор
                        cursor = 0;                                                     //курсор стоит на самой верхней строке
                    }
                }
                if (button.Key == ConsoleKey.Backspace)                                 //нажимаем backspace
                {
                    cursor = 0;                                                         //курсор стоит на самой верхней строке       
                    dir = dir.Parent;                                                   //обращаемся к изначальной папке
                    path = dir.FullName;                                                //переходим туда
                }
                if (button.Key == ConsoleKey.Delete)                                    //нажимаем delete
                {
                    if (fsi[cursor].GetType() == typeof(DirectoryInfo))                 //если это папка
                        Directory.Delete(fsi[cursor].FullName);                         //удаляем папку
                    else                                                                //если это файл
                        File.Delete(fsi[cursor].FullName);                              //удаляем файл
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FarManager far = new FarManager();
            far.Start(@"C:\Users\Acer\Downloads");
        }
    }
}
