using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class element<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        element<T> next;

        internal element<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public element(T a)
        {
            this.data = a;
            this.next = null;
        }
    }
}
