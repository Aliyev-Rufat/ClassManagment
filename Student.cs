using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Point { get; set; }


        public void StudentInfo()
        {
            Console.WriteLine($"ID {Id} Fullname {Fullname} point {Point}");
        }
    }
}
