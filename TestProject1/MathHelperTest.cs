using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    public class MathHelperTest
    {
        [Fact]
        public void When_Sum_Two_NumberDiff()
        {
            //arrange
            var str1 = "12359";
            var str2 = "6321";

            //act
            var result = MathHelper.Sum(str1, str2);

            //asset
            Assert.True(result == "18680");
        }

        [Fact]
        public void When_Sum_Two_NumberEqual()
        {
            //arrange
            var str1 = "12359";
            var str2 = "12359";

            //act
            var result = MathHelper.Sum(str1, str2);

            //asset
            Assert.True(result == "107680");
        }

        [Fact]
        public void When_Sum_Two_NumberDif()
        {
            //arrange
            var str1 = "1235";
            var str2 = "12359";

            //act
            var result = MathHelper.Sum(str1, str2);

            //asset
            Assert.True(result == "13594");
        }
    }
}
