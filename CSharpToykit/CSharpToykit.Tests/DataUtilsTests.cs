using NUnit.Framework;
using System.Collections.Generic;

namespace FineGameDesign.Utils
{
    public sealed class DataUtilsTests
    {
        private static List<int> List354()
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(4);
            return numbers;
        }

        [Test]
        public void Join_ListOfInt_Concatenates()
        {
            List<int> numbers = List354();
            Assert.AreEqual("3, 5, 4",
                DataUtils.Join(numbers, ", "));
        }

        [Test]
        public void Clear_List_Empties()
        {
            List<int> numbers = List354();
            DataUtils.Clear(numbers);
            Assert.AreEqual(0, numbers.Count);
        }

        [Test]
        public void Clear_ListAtEnd_Truncates()
        {
            List<int> numbers = List354();
            DataUtils.Clear(numbers, 2);
            Assert.AreEqual(2, numbers.Count);
            Assert.AreEqual("3, 5",
                DataUtils.Join(numbers, ", "));
        }

        [Test]
        public void Clear_ListAtMiddle_Truncates()
        {
            List<int> numbers = List354();
            DataUtils.Clear(numbers, 1);
            Assert.AreEqual(1, numbers.Count);
            Assert.AreEqual("3",
                DataUtils.Join(numbers, ", "));
        }
    }
}
