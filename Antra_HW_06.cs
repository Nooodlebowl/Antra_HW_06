// See https://aka.ms/new-console-template for more information
//GENERICS
//Q1
//Generics allow you to put any type into a parameter but allows you to control if it is the same type as another varible or what category of type
//Q2
//List<string> l = new list<string>();
//Q3
//2, the key and the value
//Q4
//True
//Q5
//ListName.add(obj);
//Q6
//listname.Remove(obj)
//listname.RemoveAt(id)
//Q7
//public static class ClassName<T>
//Q8
//False
//Q9
//True
//Q10
//True

//PRACTICING GENERICS
//Q1
using Antra_HW_06;

public class MyStack<T> 
{
    private int sLength;
    private T[] stack;
    private int top;

    public MyStack(int length)
    {
        sLength = length;
        stack = new T[sLength];
        top = 0;
    }

    int Count() 
    {
        return top;
    }

    T Pop() 
    {
        T a;
        if (top != 0) 
        {
            a = stack[top];
            stack[top] = default(T);
            top--;
            return a;
        }
        return default(T);
    }

    void Push(T a) 
    {
        if (top != sLength - 1)
        {
            stack[top + 1] = a;
        }
    }
}
//Q2
public class MyList<T> 
{
    List<T> list = new List<T>();
    void Add(T element) 
    {
        list.Add(element);
    }
    T Remove(int index) 
    {
        T element = list[index];
        list.RemoveAt(index);
        return element;
    }
    void Clear() 
    {
        list.Clear();
    }
    void InsertAt(T element, int index) 
    {
        list.Insert(index, element);
    }
    void DeleteAt(int index) 
    {
        list.RemoveAt(index);
    }
    T Find(int index)
    {
        return list[index];
    }
}

//Q3
public class Entity
{
    public int Id { get; set; }
}
public class GenericRepository<T> : IRepository<Entity>
{
    List<Entity> entities = new List<Entity>();
    public void Add(Entity item)
    {
        entities.Add(item);
    }

    public IEnumerable<Entity> GetAll()
    {
        return entities;
    }

    public Entity GetById(int id)
    {
        return entities[id];
    }

    public void Remove(Entity item)
    {
        entities.Remove(item);
    }

    public void Save()
    {
        entities = entities;
    }
}

