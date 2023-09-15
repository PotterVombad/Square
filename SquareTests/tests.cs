using Square;

namespace SquareTests
{
    [TestClass]
    public class tests
    {
        public void RadSquareTests(double radius, double result)
        {
            var decs = SquareFigures.GetSquare(radius);
            Assert.AreEqual(result, Math.Round(decs, 1));
        }
        [TestMethod]
        public void SimpleRadTest()
        {
            RadSquareTests(5, 78.5);
        }
        [TestMethod]
        public void ZeroRadTest()
        {
            RadSquareTests(0, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Radius cannot be negative.")]
        public void NegRadTest()
        {
            SquareFigures.GetSquare(-5);
        }
        public void TriangleSquareTests(double a, double b, double c, double result)
        {
            var decs = SquareFigures.GetSquare(a, b, c);
            Assert.AreEqual(result, Math.Round(decs, 1));
        }
        [TestMethod]
        public void SimpleTriangleTest()
        {
            TriangleSquareTests(5, 3, 4, 6);
        }
        [TestMethod]
        public void ZeroTriangleTest()
        {
            TriangleSquareTests(0, 3, 4, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ñatheter length cannot be negative.")]
        public void NegTriangleTest()
        {
            var result = SquareFigures.GetSquare(-5, 3, 4);
        }
        public void TriangleRightTests(double a, double b, double c, bool result)
        {
            var decs = SquareFigures.IsTriangleRight(a, b, c);
            Assert.AreEqual(result, decs);
        }
        [TestMethod]
        public void TrueTriangleRightTest()
        {
            TriangleRightTests(5, 3, 4, true);
        }
        [TestMethod]
        public void FalseTriangleRightTest()
        {
            TriangleRightTests(5, 6, 7,false);
        }
        [TestMethod]
        public void ZeroTriangleRightTest()
        {
            TriangleRightTests(6, 6, 0, false);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ñatheter length cannot be negative.")]
        public void NegTriangleRightTest()
        {
            var result = SquareFigures.IsTriangleRight(-5, 3, 4);
        }
    }
}