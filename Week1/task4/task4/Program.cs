using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());         //create size for for pyramid
            for(int i=1; i<=n; i++)                        //create 2d array, print lines
            {
                for(int j=1; j<=i; j++)                    //print coloumns
                {
                    Console.Write("[*]");                  //symbol that makes pyramid
                }
                Console.WriteLine();                       //move to the next line
            }
            Console.ReadKey();
        }
    }
}
