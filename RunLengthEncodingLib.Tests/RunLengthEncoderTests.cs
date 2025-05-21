using RunLengthEncodingLib.Encoder;

namespace RunLengthEncodingLib.Tests
{
    public class RunLengthEncoderTests
    {
        [Theory]
        [InlineData("aaabccdddddd", "3a1b2c6d")]
        [InlineData("aabbcc", "2a2b2c")]
        [InlineData("abc", "1a1b1c")]
        [InlineData("", "")]
        [InlineData("aaaaa", "5a")]
        [InlineData("a", "1a")]
        [InlineData("abbbbbc", "1a5b1c")]
        public void Encode_ReturnsExpectedOutput(string input, string expected)
        {
            // Act
            var result = RunLengthEncoder.Encode(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Encode_NullInput_ReturnsEmptyString()
        {
            // Act
            var result = RunLengthEncoder.Encode(null);

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}