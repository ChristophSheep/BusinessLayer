using xUnit;

namespace LibrarySpec
{
    public class AttributeSpec
    {
        [Fact]
        public void IsEmptySpec()
        {
            var attr = Attribute.Empty;

            var actual = Attribute.IsEmpty(attr);
            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}