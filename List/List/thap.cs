using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            element<int> a = new element<int>(4);
            element<int> b = new element<int>(5);
            element<int> c = new element<int>(6);
            List<int> list = new List<int>();

            list.addfirst(a);
            list.addfirst(b);
            list.addfirst(c);
            list.printList();
            Console.ReadKey();


        }
    }
}
