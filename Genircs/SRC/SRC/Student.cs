using System;
using System.Collections.Generic;
using System.Text;

namespace SRC
{
    public class Student : IEntity
    {
        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }


        public int ID { get; }

        public string Name { get; set; }
    }
}
