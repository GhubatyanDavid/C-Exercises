using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollectionMonths
{
    internal class Months:IEnumerable,IEnumerator
    {
        Elements[]  months = new Elements[12];
        int position = -1;
        public Elements this[int index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }
        public object Current
        {
            get
            {
                return months[position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return months.GetEnumerator();
        }

        public bool MoveNext()
        {
            if(position < months.Length-1)
            {
                position++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
