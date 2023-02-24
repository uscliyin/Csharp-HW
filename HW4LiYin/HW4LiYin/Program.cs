// See https://aka.ms/new-console-template for more information
using System;

namespace HW4 // Note: actual namespace depends on the project name.
{

    public class MyStack<T>
    {
        List<T> myStack = new List<T>();
        public void Push(T item)
        {
            myStack.Add(item);
        }
        public int Count(T item)
        {
            return myStack.Count;
        }
        public T Pop()
        {
            if (myStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T popItem = myStack[myStack.Count - 1];
            myStack.RemoveAt(myStack.Count - 1);
            return popItem;


        }
        public void PrintStack()
        {
            foreach (T item in myStack)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyList<T>
    {
        List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }
        public T Remove(int index)
        {
            T removeItem = list[index];
            list.RemoveAt(index);
            return removeItem;
        }
        public bool Contains(T item)
        {
            return list.Contains(item);
        }
        public void Clear()
        {
            list.Clear();
        }
        public void InsertAt(T item, int index)
        {
            list.Insert(index, item);
        }
        public void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }
        public T Find(int index)
        {
            return list[index];
        }
    }


    public interface IRepository<T> where T:IEntity
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IEntity
    {
        int Id { get; set; }
    }

    public class GenericRepository<T> : IRepository<T> where T:class, IEntity
    {
        List<T> list = new List<T>();
        public void Add(T item)
        {
            list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return list;
        }

        public T GetById(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void Save()
        {
            //
        }
    

    

       

    }

    class Program
    {
        static void Main(string[] args)
        {
            //MyStack<int> myStack = new MyStack<int>();
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push(3);
            //myStack.Push(4);
            //myStack.Pop();
            //myStack.PrintStack();


            //MyList<int> myList = new MyList<int>();

            //GenericRepository<class>=new GenericRepository<class>();
    }
    }
}
