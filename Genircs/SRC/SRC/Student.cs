using System;
using System.Collections.Generic;
using System.Text;

namespace SRC
{
    public class Student
    {
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
