using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class FarManager
    {
        public int cursor;
        public int size;
        public bool b;

        public FarManager()
        {
            cursor = 0;
            b = true;
        }

        public void Up()
        {
            cursor--;
            if (cursor < 0)
            {
                cursor = size - 1;
            }
        }

        public void Down()
        {
            cursor++;
            if (cursor == size)
            {
                cursor = 0;
            }
        }

        public void Color(FileSystemInfo file, int index)
        {
            if (index == cursor)
                Console.BackgroundColor = ConsoleColor.Magenta;
            else if (file.GetType() == typeof(DirectoryInfo))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }

        public void Show(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] files = directory.GetFileSystemInfos();
            size = files.Length;
            int index = 0;
            foreach (FileSystemInfo fs in files)
            {
                Color(fs, index);
                Console.WriteLine(index + 1 + ". " + fs.Name);
                index++;
            }
        }

        public void Start(string path)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Show(path);
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                    Up();
                else if (key.Key == ConsoleKey.DownArrow)
                    Down();

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
