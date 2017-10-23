using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Tests
{
    public class GenericListEnumerator<X> : IEnumerator<X>
    {
        private int index = -1;
        private IGenericList<X> _list;

        public GenericListEnumerator(IGenericList<X> list)
        {
            _list = list;
        }

        public X Current
        {
            get { return _list.GetElement(index); }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            index++;

            if (index > _list.Count - 1)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public void Dispose()
        {
        }
    }
}
