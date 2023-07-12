using Xunit;
using DataStructureAlgo;

namespace SampleTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void SearchSuccessTest()
        {
            Algorithms algo = new Algorithms(new int[4] { 2, 4, 6, 7 });

            int? result = algo.binarySearch(2, out int tries);

            Assert.True(result > 0);
        }


        [Fact]
        public void SearchFailedTest()
        {
            Algorithms algo = new Algorithms(new int[4] { 2, 4, 6, 7 });

            int? result = algo.binarySearch(9, out int tries);

            Assert.True(result == null);
        }
    }
}
