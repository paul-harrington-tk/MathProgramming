namespace MathUnitTests
{
    using MathLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StringLibrary;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LevensteinTest()
        {
            var stringA = "hicken";
            var stringB = "hurch";
            var distance = stringA.LevensteinDistance(stringB);
            Assert.IsTrue(distance == 3);
        }

        [TestMethod]
        public void BinaryGapTest()
        {
            var firstVal = 52;
            var gap = firstVal.BinaryGapRegex();
            Assert.IsTrue(gap == 1);
        }

        [TestMethod]
        public void EquilibriumIndexTest()
        {
            var a = new[] {-7, 1,5,2,-4,3,0};
            var equi = a.EquilibriumIndex();
            Assert.IsTrue(equi == 3);
        }

        [TestMethod]
        public void LeftShiftTest()
        {
            var input = new[] { 3, 8, 9, 7, 6};
            var res = input.LeftShift(3);
            var expected = new[] {9, 7, 6, 3, 8};

            for (var i = 0; i < res.Length; i++)
            {
                Assert.IsTrue(res[i] == expected[i]);
            }

            input = new int[0];
            res = input.LeftShift(0);
            Assert.AreEqual(res, input);
        }

        [TestMethod]
        public void PermMissingElementTest()
        {
            var empty = new int[0];
            var res = empty.PermMissingElement();
            Assert.IsTrue(res == 1);
            var single = new[] {2};
            res = single.PermMissingElement();
            Assert.IsTrue(res == 1);
            var dbl = new[] {1, 3};
            Assert.IsTrue(dbl.PermMissingElement() == 2);

            var last = new [] {4, 2, 1, 3, 6};
            var first = new [] {6, 3, 5, 4, 2};
            res = first.PermMissingElement();
            Assert.IsTrue(res == 1);
            res = last.PermMissingElement();
            Assert.IsTrue(res == 5);
        }

        [TestMethod]
        public void IsPermutationTest()
        {
            var permArray = new [] {4, 1, 2, 3};
            var res = permArray.IsPermutation();
            Assert.IsTrue(res == 1);
        }
    }
}
