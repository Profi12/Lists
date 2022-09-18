using ListsLibrary;
using NUnit.Framework;
using System;

namespace ListsTests
{
    public class ArrayListTests
    {
        [Test]
        public void DefaultConstructor_WhenCalled_ShouldBeEquivalentToEmptyArray()
        {
            ArrayList aList = new ArrayList();

            CollectionAssert.AreEqual(new int[] { }, aList);
        }

        [TestCase(new int[] { }, 4, 0)]
        [TestCase(new int[] { 10 }, 4, 1)]
        [TestCase(new int[] { 10, 2, 1 }, 4, 3)]
        [TestCase(new int[] { 10, 2, 1, 5 }, 4, 4)]
        [TestCase(new int[] { 10, 2, 1, 5, 6 }, 5, 5)]
        public void ArrayConstructor_WhenArrayPassed_ShouldCreateArray(
            int[] inputArray, int capacity,int length)
        {
            ArrayList aList = new ArrayList(inputArray);

            CollectionAssert.AreEqual(inputArray, aList);
            Assert.AreEqual(capacity, aList.Capacity);
            Assert.AreEqual(length, aList.Length);
        }

        [Test]
        public void ArrayConstructor_WhenNullPassed_ShouldThrowArgumentException()
        {
            try
            {
                new ArrayList(null);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(4)]
        [TestCase(5)]
        [TestCase(10)]
        public void CapacityConstructor_WhenValidCapacity_ShouldSetCapacity(
            int capacity)
        {
            ArrayList aList = new ArrayList(capacity);

            Assert.AreEqual(capacity, aList.Capacity);
            Assert.AreEqual(0, aList.Length);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void CapacityConstructor_WhenLowCapacity_ShouldSetDefaultCapacity(int capacity)
        {
            ArrayList aList = new ArrayList(capacity);

            Assert.AreEqual(0, aList.Length);
            Assert.AreEqual(4, aList.Capacity);
        }

        [Test]
        public void CapacityConstructor_WhenCapacityLowerZero_ShouldThrowArgumentException()
        {
            try
            {
                new ArrayList(-10);
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}