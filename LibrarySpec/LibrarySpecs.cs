using System;
using Xunit;

namespace LibrarySpec
{
    public class LibrarySpecs
    {
        [Fact]
        public void TestHereSomething()
        {
            var expected = 1;
            var actual = 1;

            Assert.Equal(expected, actual);
        }
    }
}
