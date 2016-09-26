using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T>
    {
        element<T> head;


        internal element<T> Head
        {
            get { return head;
            }
            set { head = value; }
        }

        
       public void addfirst(element<T> e)
        {
            e.Next = head;                                                                                                                                                         
            this.head = e;
        }
        public List()
       {
           this.head = null;
       }
        public void printList()
       {
           element<T> point = head;
           while (point != null)
           {
               Console.WriteLine(point.Data);
              point=point.Next;
           }
       }

    }
}
