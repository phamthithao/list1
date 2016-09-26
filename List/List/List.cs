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


        public List()
        {
        }
       
       public void addfirst(element<T> e)
        {
            e.Next = head;
            this.head = e;
        }
    }
}
