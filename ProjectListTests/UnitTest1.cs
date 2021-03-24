using NUnit.Framework;
using ProjectList;

namespace ProjectListTests
{
    public class ListsTests
    {
        [TestCase(new int[] {1, 2, 3, 4 }, 5, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 5, new int[] { 1, 2, 356, 4, 5 })]
        [TestCase(new int[] { 1, 212, 3, 412 }, 543, new int[] { 1, 212, 3, 412, 543 })]
        public void AddTest(int[] inputArray, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 5, new int[] {5, 1, 2, 356, 4 })]
        [TestCase(new int[] { 1, 212, 3, 412 }, 543, new int[] { 543, 1, 212, 3, 412 })]
        public void AddToTheBegginingTest(int[] inputArray, int value, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.AddToTheBeggining(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 5, 0, new int[] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 5, 3, new int[] { 1, 2, 356, 5, 4 })]
        [TestCase(new int[] { 1, 212, 3, 412 }, 543, 4, new int[] { 1, 212, 3, 412, 543 })]
        public void AddByIndexTest(int[] inputArray, int value, int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.AddByIndex(value, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, new int[] { 1, 2, 356 })]
        [TestCase(new int[] { 1, 212, 3, 412 }, new int[] { 1, 212, 3 })]
        public void RemoveLastElementTest(int[] inputArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.RemoveLastElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, new int[] { 2, 356, 4 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, new int[] { 1, 212, 3, 412 })]
        public void RemoveFirstElementTest(int[] inputArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.RemoveFirstElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 3, new int[] {1, 2, 356 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 3, new int[] {58, 1, 212, 412 })]
        public void RemoveElementByIndexTest(int[] inputArray,int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.RemoveElementByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 3, new int[] { 1 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 3, new int[] { 58, 1 })]
        public void RemoveNLastElementsTest(int[] inputArray, int N, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.RemoveNLastElements(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 3, new int[] { 4 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 3, new int[] { 3, 412 })]
        public void RemoveNFirstElementsTest(int[] inputArray, int N, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.RemoveNFirstElements(N);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 1, new int[] { 1, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 4 }, 2,  1, new int[] { 1, 4 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 },2, 3, new int[] { 58, 1, 212 })]
        public void RemoveNElementsByIndexTest(int[] inputArray, int N, int index, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.RemoveNElementsByIndex(N, index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, 2)]
        [TestCase(new int[] { 1, 2, 356, 4 }, 2, 356)]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 3, 3)]
        public void GetElementByIndexTest(int[] inputArray, int index, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.GetElementByIndex(index);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, 3, 2)]
        [TestCase(new int[] { 1, 2, 356, 2, 2, 4 }, 2, 1)]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 3, 3)]
        public void GetIndexOfElementTest(int[] inputArray, int x, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.GetIndexOfElement(x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, 3, 2, new int[] { 1, 2, 3, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 356, 2, 2, 4 }, 2, 1, new int[] { 1, 2, 1, 2, 2, 4 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 4, 3, new int[] { 58, 1, 212, 3, 3 })]
        public void ChangeIndexNTest(int[] inputArray, int N, int x, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.ChangeIndexN( N, x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, new int[] { 4, 3, 3, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 356 }, new int[] { 356, 2, 1 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, new int[] { 412, 3, 212, 1, 58 })]
        public void ReverseTest(int[] inputArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 2, 356, 2, 2, 4 }, 356)]
        [TestCase(new int[] { 58, 1, 412, 3, 412 }, 412)]
        public void SearchMaxValueTest(int[] inputArray, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.SearchMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -1, 2, 3, 3, 3, 4 }, -1)]
        [TestCase(new int[] { 1, 2, -356, 2, 2, 4 }, -356)]
        [TestCase(new int[] { 58, 1, -212, 3, 412 }, -212)]
        public void SearchMinValueTest(int[] inputArray, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.SearchMinValue();
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase(new int[] { 1, 2, 2, 4, 6, 8, 2}, 5)]
        [TestCase(new int[] { 1, 2, 356, 2, 2, 4 }, 2)]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 4)]
        public void SearchIndexOfMaxValueTest(int[] inputArray, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.SearchIndexOfMaxValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 2, 2, 3, -121, 3, 4 }, 3)]
        [TestCase(new int[] { 1, 2, -356, 2, 2, 4 }, 2)]
        [TestCase(new int[] { 58, -11, 212, 3, 412 }, 1)]
        public void SearchIndexOfMinValueTest(int[] inputArray, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.SearchIndexOfMinValue();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, new int[] { 1, 2, 3, 3, 3, 4 })]
        [TestCase(new int[] { 1, 521, 2, 356 }, new int[] { 1, 2, 356, 521 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, new int[] { 1, 3, 58, 212, 412 })]
        public void SortingByIncreaseTest(int[] inputArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.SortingByIncrease();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, new int[] { 4, 3, 3, 3, 2, 1 })]
        [TestCase(new int[] { 1, 521, 2, 356 }, new int[] { 521, 356, 2, 1 })]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, new int[] { 412, 212, 58, 3, 1 })]
        public void SortingByDecreaseTest(int[] inputArray, int[] expectedArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(inputArray);
            actual.SortingByDecrease();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, 2, 1)]
        [TestCase(new int[] { 1, 2, -356, 2, 2, 4 }, -356, 2)]
        [TestCase(new int[] { 58, 1, 212, 3, 412 }, 3, 3)]
        public void RemoveElementXTest(int[] inputArray, int x, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.RemoveElementX(x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 3, 3, 4 }, 3, 3)]
        [TestCase(new int[] { 1, 2, -356, 2, 2, 4 }, 2, 3)]
        [TestCase(new int[] { 58, 1, 212, 3, 212, 212 }, 212, 3)]
        public void RemoveAllElementsXTest(int[] inputArray, int x, int expected)
        {
            ArrayList list = new ArrayList(inputArray);
            int actual = list.RemoveAllElementsX(x);
            Assert.AreEqual(expected, actual);
        }
    }
}