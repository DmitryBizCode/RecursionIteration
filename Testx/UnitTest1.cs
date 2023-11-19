using RecursionIter;

namespace Testx
{
    public class UnitTest1
    {
        [Fact]
        public void IterVsRecursive()
        {
            var cos = new Cosinus(3.14);
            var iter = Math.Round(cos.Iterative(), 4);
            var rec = Math.Round(cos.Recursion(), 4);
            Assert.Equal(iter, rec, 0.0001);
        }
        [Fact]
        public void IterVsMathcos()
        {
            var cos = new Cosinus(3.14);
            var expected = Math.Round(cos.Iterative(), 4);
            var actual = Math.Round(Math.Cos(3.14), 4);
            Assert.Equal(expected, actual);
        }
    }
}