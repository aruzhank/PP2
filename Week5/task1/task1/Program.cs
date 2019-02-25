using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
    public class Complex
    {
        public double a;
        public double b;
        public Complex()
        {

        }
        public void Print()
        {
            Console.WriteLine(a + "+" + b + "i");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F1();
        }

        private static void F2()
        {
            FileStream fs = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Complex));
            Complex cm = xml.Deserialize(fs) as Complex;
            fs.Close();
        }

        private static void F1()
        {
            Complex num = new Complex();
            num.a = 8;
            num.b = 7;
            num.Print();
            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Complex));
            xml.Serialize(fs, num);
            fs.Close();
        }
    }
}
