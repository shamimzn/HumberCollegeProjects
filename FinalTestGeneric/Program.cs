using System;
using System.Collections.Generic;

namespace FinalTestGeneric
{
    class Program
    {
        static void Main(string[] args)
        {

          

            int[] cars = { 4, 6, 1, 9 };
                          

            MyGenericClass<int>.AddItem(cars);

            Console.WriteLine("Get Item 2 :  {0}",MyGenericClass<int>.GetSingleItem(2).ToString());

            foreach (int str in MyGenericClass<int>.GetAllSortedDesc())
             Console.WriteLine(str.ToString());

        }
    }

    public  static class MyGenericClass<T>
    {
        

        private static  List<T> myList;

        public static void AddItem(T[] items)
        {
            myList = new List<T>();
            foreach (T item in items)
            {
                myList.Add(item);
            }
        }

        public static T GetSingleItem(int Index)
        {
            return myList[Index];
        }

        public static List<T> GetAllSortedDesc()
        {
            myList.Sort(); //it sortes acending
            myList.Reverse(); // it sorts Descending
            return myList;
        }
    }
}
