using System;
using System.Collections.Generic;
using System.Text;

namespace SRC;

public class CourseStore
{
    private readonly List<Course> _Course = [];



    public void ADD(Course course)
   => _Course.Add(course);

    public Course? GetByID(int iD)
    {
        foreach (var st in _Course)
        {
            if (st.ID == iD)
            {
                return st;
            }
        }
        return null;
    }

    public IReadOnlyList<Course> GetAll()
      => _Course;
    public void Remove(int id)
    {
        foreach (var st in _Course)
        {
            if (st.ID == id)
            {
                _Course.Remove(st);
            }
        }
    }
}
