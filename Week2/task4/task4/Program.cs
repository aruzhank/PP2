using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir1 = "folder1";                                         
            string dir2 = "folder2";                                        
            string text = "example.txt";

            string s = (@"C:\Users\Acer");                                    //directory's path, where folders and files will be created
            string p1 = Path.Combine(s, dir1);                               //path to the "folder1"
            string p2 = Path.Combine(s, dir2);                               //path to the "folder2"
          
            Directory.CreateDirectory(p1);                                    //create "folder1"

            string fileSource = Path.Combine(p1, text);                       //path to the given file

            FileStream fs = File.Create(fileSource);                          //stream to create file by given path
            fs.Close();                                                       //close file
            
            Directory.CreateDirectory(p2);                                    //create "folder2"

            string fileDest = Path.Combine(p2, text);                         //path to the folder, where we copy file
            File.Copy(fileSource, fileDest);                                  //copy a file to "folder2"
            File.Delete(fileSource);                                          //delete original file
            Directory.Delete(p1);                                             //delete folder, where file was located
        }
    }
}

