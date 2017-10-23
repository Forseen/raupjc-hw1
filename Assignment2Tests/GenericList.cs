using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Tests
{
    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        public int Count { get; private set; }

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int sizeCount)
        {
            _internalStorage = new X[Math.Abs(sizeCount)];
        }
        public void Add(X item)
        {
            if (_internalStorage.Length == Count)
            {
                Array.Resize(ref _internalStorage, 2 * _internalStorage.Length);
            }
            _internalStorage[Count] = item;
            Count++;
        }

        public bool Remove(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index + 1 > Count)
            {
                throw new IndexOutOfRangeException("The index is out of range");
            }
            for (int i = index; i < Count - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }

            Count--;
            return true;
        }

        public X GetElement(int index)
        {
            if (index > -1 && index < Count)
            {
                return _internalStorage[index]; 
            }
            else
            {
                throw new IndexOutOfRangeException("The index is out of range");
            }
        }

        public int IndexOf(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
