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
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(1);
            test1.Add(2);
            test1.Add(3);
            test1.Add(4);
            test1.Add(5);


            test1.Remove(5);
               
        }
    }
}
