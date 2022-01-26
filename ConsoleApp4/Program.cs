using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp4
{
    public class MyList<T>
    {
        private List<T> _list;
        public MyList()
        {
            _list = new List<T>();
        }

        public void Add(T element)
        {
            _list.Add(element);
        }

        public MyList<T> Where(Func<T,bool> callback)
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in _list)
            {
                if(callback(item) == true)
                {
                    result.Add(item);
                }
            }

            return result;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Callbacks & Delegates & Anonym methods

            // int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };

            //GetCountOfLogicalResult(numbers, a =>
            //{
            //    if (a >= 100)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //});

            //Lambda expression


            //Action
            //Func

            //Where 
            //FirstOrDefault 
            //Any
            //All
            //ToList

            MyList<string> myStudents = new MyList<string>();

            myStudents.Add("Terlan");
            myStudents.Add("Cavid");
            myStudents.Add("Babek");
            myStudents.Add("Eli");

            myStudents.Where(a => a == "Cavid");
            myStudents.All(a => a == "Cavid");
            myStudents.Any(a => a == "Cavid");
            myStudents.FirstOrDefault();

          

        }

        public static int GetCountOfLogicalResult(int[] array,Func<int,bool> logic)
        {
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(logic(array[i]) == true)
                {
                    counter++;
                }
                

            }

            return counter;
        }

       
    }
}
