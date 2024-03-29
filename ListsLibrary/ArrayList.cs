﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListsLibrary
{
    public class ArrayList : IList
    {
        private const int DefaultSize = 4;
        private int[] _array;
        private int _count;

        public int Length => _count;
        public int Capacity => _array.Length;

        public ArrayList() : this(DefaultSize) { }

        public ArrayList(int[] startArray)
        {
            if(startArray == null)
            {
                throw new ArgumentException();
            }

            int size = startArray.Length < DefaultSize ? DefaultSize : startArray.Length;
            _array = new int[size];

            for (int i = 0; i < startArray.Length; i++)
            {
                _array[i] = startArray[i];
            }

            _count = startArray.Length;
        }

        public ArrayList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException();
            }

            capacity = capacity < DefaultSize ? DefaultSize : capacity;
            _array = new int[capacity];
        }

        public void AddBack(int element)
        {
            UpdateCapacity();

            _array[_count++] = element;
        }

        public void AddBack(IList list)
        {
            throw new NotImplementedException();
        }

        public void AddByIndex(int index, int element)
        {
            UpdateCapacity();

            for (int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = element;
            ++_count;
        }

        public void AddByIndex(int index, IList list)
        {
            throw new NotImplementedException();
        }

        public void AddFront(int element)
        {
            UpdateCapacity();

            for (int i = Length; i > 0; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[0] = element;
            ++_count;
        }

        public void AddFront(IList list)
        {
            AddByIndex(0, list);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return _array[i];
            }
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOfMax()
        {
            if (Length == 0)
            {
                throw new ArgumentException();
            }

            int maxI = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > _array[maxI])
                {
                    maxI = i;
                }
            }

            return maxI;
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
            return GetEnumerator();
        }

        private void UpdateCapacity()
        {
            if (Length == Capacity)
            {
                int newSize = (int)(Capacity * 1.33);
                int[] newArray = new int[newSize];
                for (int i = 0; i < Length; i++)
                {
                    newArray[i] = _array[i];
                }

                _array = newArray;
            }
        }
    }
}
