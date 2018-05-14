using Xunit;
using Consumer;

namespace ConsumerTest
{
    public class HomeModuleTest
    {
        [Fact]
        public void PassingTest()
        {
            Consumer.HomeModule home = new Consumer.HomeModule();
            Assert.Equal(4, Add(2, 2));
        }

        // [Fact]
        // public void FailingTest()
        // {
        //     Assert.Equal(5, Add(2, 2));
        // }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}