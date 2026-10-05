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
    private readonly Dictionary<int,T> _Store = [];

    public void ADD(int id,T st)
    {
        if (_Store.ContainsKey(id)) throw new ArgumentException("The Key Ordey Exsit");
        _Store.Add(id,st);
    }
   

    public T? GetByID(int iD)
    {
        if (_Store.TryGetValue(iD,out T? Result))
        {
            return Result;
        }
        return null;
    }

    public IReadOnlyDictionary<int,T> GetAll()
      => _Store;
    public void Remove(int id)
    {
        if (_Store.ContainsKey(id)) _Store.Remove(id);
    }
}
