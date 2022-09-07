using System;

class Program
{
    static void Main(string[] args)
    { 
    }

    class Stack<T>
    {
        public List<T> list { get; set; }


        public void Push<T>(List<T> list, T obj) // - adds obj at the top of stack
        {
            list.Add(obj);
        }
        public List<T> Pop(List<T> list, int col) // - returns top element of stack & removes it
        {
            List<T> result = new List<T>();
            for (int i = 0; i < col; i++)
            {
                result.Add(list[i]);
                list.RemoveAt(i);
            }
            return result;
        }
        public void Clear(List<T> list)// - clear stack
        {
            list.Clear();
        }

        public int Count(List<T> list, T el) //- property return number of elements
        {
            return list.IndexOf(el);
        }

        public List<T> Peek(List<T> list, int col) //- returns top element but doesn’t remove it
        { 

         List<T> result = new List<T>();
        
            for (int i = 0; i < col; i++)
            {
                result.Add(list[i]);          
            }

            return result;
        }

        public void CopyTo(List<T> list, T[] arr) // copies stack to array
        {
            int i = 0;
            foreach (var el in list)
            {
                arr[i] = el;
                i++;
            }
        }
    }
}
