using System;
using System.Collections.Generic;
using System.Text;

namespace ListsLibrary
{
    public class ArrayList : IList
    {
        private int[] _array;
        private int _count;

        public int Length => _count;
        public int Capacity => _array.Length;

        public ArrayList()
        {
            _array = new int[4];
        }

        public ArrayList(int[] startArray)
        {
            _array = new int[startArray.Length];
            for (int i = 0; i < startArray.Length; i++)
            {
                _array[i] = startArray[i];
            }

            _count = startArray.Length;
        }

        public void AddBack(int element)
        {
            throw new NotImplementedException();
        }

        public void AddBack(IList list)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, int element)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, IList list)
        {
            throw new NotImplementedException();
        }

        public void AddFront(int element)
        {
            throw new NotImplementedException();
        }

        public void AddFront(IList list)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int element)
        {
            throw new NotImplementedException();
        }

        public int IndexOfMax()
        {
            throw new NotImplementedException();
        }

        public int IndexOfMin()
        {
            throw new NotImplementedException();
        }

        public int Max()
        {
            throw new NotImplementedException();
        }

        public int Min()
        {
            throw new NotImplementedException();
        }

        public int RemoveAllByValue(int value)
        {
            throw new NotImplementedException();
        }

        public int RemoveBack()
        {
            throw new NotImplementedException();
        }

        public int RemoveByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public int RemoveByValue(int value)
        {
            throw new NotImplementedException();
        }

        public int RemoveFront()
        {
            throw new NotImplementedException();
        }

        public int RemoveNElementsBack(int count)
        {
            throw new NotImplementedException();
        }

        public void RemoveNElementsByIndex(int index, int count)
        {
            throw new NotImplementedException();
        }

        public void RemoveNElementsFront(int count)
        {
            throw new NotImplementedException();
        }

        public void Sort(bool ascending = true)
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
