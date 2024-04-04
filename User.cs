using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Point { get; set; }

        public User(int id, string fullname, string point)
        {
            Id = id;
            Fullname = fullname;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Fullname: {Fullname}, Point: {Point}");
        }

    }
}
