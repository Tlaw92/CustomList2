using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListRound2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> test1 = new CustomList<int>();
            //test1.Add(1);
            //test1.Add(2);
            //test1.Add(3);
            //test1.Add(4);
            //test1.Add(5);

            //Console.WriteLine(test1.Count); 
            //test1.Remove(2);
            //Console.WriteLine(test1.Count);
            //Console.ReadLine();


            //

            //CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            //CustomList<int> two = new CustomList<int>() { 2, 1, 6 };
            //CustomList<int> result = one - two;


            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> result = CustomList<int>.Zipper(one, two);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
