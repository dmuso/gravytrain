using Xunit;
using Gravytrain;

namespace GravytrainTest
{
    public class HomeModuleTest
    {
        [Fact]
        public void PassingTest()
        {
            Gravytrain.HomeModule home = new Gravytrain.HomeModule();
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