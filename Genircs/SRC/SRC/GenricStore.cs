using System;
using System.Collections.Generic;
using System.Text;

namespace SRC;

public interface IEntity
{
    public int ID { get; }
}

public class GenricStore<T>
    where T :class,IEntity
{
    private readonly List<T> _Store = [];

    public void ADD(T st)
   => _Store.Add(st);

    public T? GetByID(int iD)
    {
        foreach (var st in _Store)
        {
            if (st.ID == iD)
            {
                return st;
            }
        }
        return null;
    }

    public IReadOnlyList<T> GetAll()
      => _Store;
    public void Remove(int id)
    {
        foreach (var st in _Store)
        {
            if (st.ID == id)
            {
                _Store.Remove(st);
            }
        }
    }
}
