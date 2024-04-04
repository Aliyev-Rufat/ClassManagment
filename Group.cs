using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private Student[] Students { get; set; }

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            Students = new Student[studentLimit];
        }

        public bool CheckGroupNo(string groupNo)
        {
            return groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsUpper(groupNo[2]) && char.IsUpper(groupNo[3]) && char.IsUpper(groupNo[4]);
        }


        public bool AddStudent(Student student)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == null)
                {
                    Students[i] = student;
                    return true;
                }
            }
            return false;
        }

        public bool GetStudent(int ID)
        {
            foreach (Student student in Students)
            {
                if (student.Id == ID)
                {
                    return true;
                }
            }
            return false;
        }



        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}
