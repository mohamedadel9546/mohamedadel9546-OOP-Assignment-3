using System;
using System.Collections.Generic;
using System.Text;

namespace SRC;


public class StudentStore
{
    private readonly List<Student> students = [];
    


    public void ADD(Student Student)
   => students.Add(Student);

    public Student? GetByID(int iD)
    {
        foreach(var st in students)
        {
            if (st.Id == iD)
            {
                return st;
            }     
        }
        return null;
    }

    public IReadOnlyList<Student> GetAll()
      => students;
    public void Remove(int id)
    {
        foreach (var st in students)
        {
            if (st.Id == id)
            {
                students.Remove(st);
            }
        }
    }
  
}




