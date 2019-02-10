using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;      //set name
        public string id;        //set id
        public int year;         //set year

        public Student(string name, string id)      //method for name and id
        {
            this.name = name;
            this.id = id;
        }

        public void addYear()            //method for increment year
        {
            year++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Aruzhan", "18BD110485");     //declare name and id
            s.year = 1;                                           //declare year
            s.addYear();                                          //make method increment year
            Console.Write(s.name + " " + s.id + " " + s.year);    //print name,id,year(increment)
            Console.ReadKey();
        }
    }
}
