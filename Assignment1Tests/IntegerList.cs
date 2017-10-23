using System;
using System.Collections.Generic;

namespace Assignment1Tests
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        public int Count { get; private set; }

        public IntegerList()
        {
            _internalStorage = new int[4];
        }

        public IntegerList(int sizeCount)
        {
            _internalStorage = new int[Math.Abs(sizeCount)];
        }
        
        public void Add(int item)
        {
            if (_internalStorage.Length == Count)
            {
                Array.Resize(ref _internalStorage, 2*_internalStorage.Length);
            }
            _internalStorage[Count] = item;
            Count++;
        }

        public bool Remove(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
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

        public int GetElement(int index)
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

        public int IndexOf(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
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

        public bool Contains(int item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
