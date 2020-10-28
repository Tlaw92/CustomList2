using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomListRound2
{
    public class CustomList<T>
    {
        //member variables(has a)
        int count;
        int capacity;
        T[] items;

        //properties for count and capacity
        public int Count { get { return count; } }
        //public int Capacity { get { return capacity; } }

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
            items = new T[capacity];
            count = 0;
            
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
    }
}
