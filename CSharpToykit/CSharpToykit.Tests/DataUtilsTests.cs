using NUnit.Framework/*<Test>*/;
using System.Collections.Generic/*<List>*/;

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
        public void JoinListOfInt()
        {
            List<int> numbers = List354();
            Assert.AreEqual("3, 5, 4",
                DataUtils.Join(numbers, ", "));
        }

        [Test]
        public void ClearList()
        {
            List<int> numbers = List354();
            DataUtils.Clear(numbers);
            Assert.AreEqual(0, DataUtils.Length(numbers));
        }

        [Test]
        public void ClearListAtEnd()
        {
            List<int> numbers = List354();
            DataUtils.Clear(numbers, 2);
            Assert.AreEqual(2, DataUtils.Length(numbers));
            Assert.AreEqual("3, 5",
                DataUtils.Join(numbers, ", "));
        }

        [Test]
        public void ClearListAtMiddle()
        {
            List<int> numbers = List354();
            DataUtils.Clear(numbers, 1);
            Assert.AreEqual(1, DataUtils.Length(numbers));
            Assert.AreEqual("3",
                DataUtils.Join(numbers, ", "));
        }
    }
}
