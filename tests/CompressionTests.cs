using algorithms;
using Xunit;

namespace tests
{
    public class CompressionTests
    {
        [Fact]
        public void ShouldCompressWhenCompressionIsSmaller()
        {
            string input = "aabcccc";
            Assert.Equal("a2b1c4", Compression.Compress(input));
        }

        [Fact]
        public void ShouldNotCompressWhenCompressionIsGreater()
        {
            string input = "abc";
            Assert.Equal("abc", Compression.Compress(input));
        }
    }
}