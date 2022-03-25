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

        public ArrayList() : this(4) { }

        public ArrayList(int[] startArray)
        {
            _array = new int[startArray.Length];
            for (int i = 0; i < startArray.Length; i++)
            {
                _array[i] = startArray[i];
            }

            _count = startArray.Length;
        }

        public ArrayList(int capacity)
        {
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
            throw new NotImplementedException();
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
