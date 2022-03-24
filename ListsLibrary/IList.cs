using System;
using System.Collections.Generic;

namespace ListsLibrary
{
    public interface IList : IEnumerable<int>
    {
        void AddFront(int element);
        void AddByIndex(int index, int element);
        void AddBack(int element);
        void AddFront(IList list);
        void AddByIndex(int index, IList list);
        void AddBack(IList list);
        int RemoveFront();
        int RemoveByIndex(int index);
        int RemoveBack();
        void RemoveNElementsFront(int count);
        void RemoveNElementsByIndex(int index, int count);
        int RemoveNElementsBack(int count);
        int IndexOf(int element);
        int Length { get; }
        int Max();
        int Min();
        int IndexOfMax();
        int IndexOfMin();
        void Sort(bool ascending = true);
        int RemoveByValue(int value);
        int RemoveAllByValue(int value);
    }
}
