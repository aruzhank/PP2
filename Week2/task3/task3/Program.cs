using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public static void PrintSpaces(int n)                                    //creating a function
        {
            for (int i = 0; i < n; i++)
                Console.Write("   ");
        }

        public static void Dir(DirectoryInfo dir, int a)                         //creating a function that will show every folder and file 
        {
            FileInfo[] files = dir.GetFiles();                                   //getting files
            DirectoryInfo[] directories = dir.GetDirectories();                  //getting directories

            foreach (FileInfo file in files)                                     //considering each file
            {
                PrintSpaces(a);
                Console.WriteLine(file.Name);                                    //getting file's name
            }

            foreach (DirectoryInfo direct in directories)                        //considering each directory
            {
                PrintSpaces(a);
                Console.WriteLine(direct.Name);                                  //getting directory's name
                Dir(dir, a + 1);                                                 //recursion
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Acer\Downloads");      //getting access to directory
            Dir(d, 0);                                                            //calling function
            Console.ReadKey();
        }
    }
}
