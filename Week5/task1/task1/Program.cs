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
            a = 8;
            b = 7;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            F2();
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
            Complex c = new Complex();
            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Complex));
            xml.Serialize(fs, c);
            fs.Close();
        }
    }
}
