using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace CustomListRound2
{
    public class CustomList<T> : IEnumerable
    {
        //member variables(has a)
        int count;
        int capacity;
        T[] items;

        //properties for count and capacity
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }

        //Indexer
        public T this[int index]
        {
            get
            {

                if (index >= 0 && index <= count)
                {
                    return items[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index <= count)
                {
                    items[index] = value;
                }
            }
        }

        //constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //methods

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return items[index];
            }
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                T[] temporaryArray = new T[capacity *= 2];
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = items[i];                    
                }
                items = temporaryArray;
            }

            items[count] = itemToAdd;
            count++;
        }

        public bool Remove(T itemToRemove)
        {
            bool foundItem = false;
            T[] temporaryArray = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (items[i].Equals(itemToRemove) && foundItem == false)
                {
                    foundItem = true;

                    j--;
                }
                else
                {
                    temporaryArray[j] = items[i];
                }
            }
            if (foundItem == true)
            {
                count--;
            }
            items = temporaryArray;
            return foundItem;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(items[i].ToString());
            }

            return builder.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> A, CustomList<T> B)
        {
            CustomList<T> items2 = new CustomList<T>();
            for (int i = 0; i < A.Count; i++)
            {
                items2.Add(A[i]);
            }
            for (int i = 0; i < B.Count; i++)
            {
                items2.Add(B[i]);
            }
            return items2;
        }

        public static CustomList<T> operator -(CustomList<T> A, CustomList<T> B)
        {
            CustomList<T> items2 = new CustomList<T>();
            for (int i = 0; i < A.Count; i++)
            {
                items2.Add(A[i]);
            }
            for (int i = 0; i < B.Count; i++)
            {
                items2.Remove(B[i]);
            }
            return items2;
        }

        public static CustomList<T> Zipper(CustomList<T> A, CustomList<T> B)
        {
            CustomList<T> items3 = new CustomList<T>();
            for (int i = 0; i < A.Count; i++)
            {
                items3.Add(A[i]);
                items3.Add(B[i]);
            }
            return items3;
        }
    }
}
