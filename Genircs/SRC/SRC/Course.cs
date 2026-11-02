using System;
using System.Collections.Generic;
using System.Text;

namespace SRC
{
    public class Course:IEntity
    {
        public Course(int iD, string title, decimal price)
        {
            ID = iD;
            Title = title;
            Price = price;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
