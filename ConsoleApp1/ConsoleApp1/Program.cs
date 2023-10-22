using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //мейн не скопировал когда сохранял
        }

        public class MyCollection<T>
        {
            private ArrayList arrayListItems = new ArrayList();
            private List<T> listItems = new List<T>();
            private Stack<T> stackItems = new Stack<T>();
            private Queue<T> queueItems = new Queue<T>();

            public void AddArrayList(object item)
            {
                arrayListItems.Add(item);
            }

            public void RemoveArrayList(object item)
            {
                arrayListItems.Remove(item);
            }

            public object GetArrayList(int index)
            {
                return arrayListItems[index];
            }

            public int CountArrayList()
            {
                return arrayListItems.Count;
            }




            public void AddList(T item)
            {
                listItems.Add(item);
            }

            public void RemoveList(T item)
            {
                listItems.Remove(item);
            }

            public T GetList(int index)
            {
                return listItems[index];
            }

            public int CountList()
            {
                return listItems.Count;
            }





            public void PushStack(T item)
            {
                stackItems.Push(item);
            }

            public T PopStack()
            {
                return stackItems.Pop();
            }

            public T PeekStack()
            {
                return stackItems.Peek();
            }

            public int CountStack()
            {
                return stackItems.Count;
            }




            public void EnqueueQueue(T item)
            {
                queueItems.Enqueue(item);
            }

            public T DequeueQueue()
            {
                return queueItems.Dequeue();
            }

            public T PeekQueue()
            {
                return queueItems.Peek();
            }

            public int CountQueue()
            {
                return queueItems.Count;
            }
        }

    }
}
