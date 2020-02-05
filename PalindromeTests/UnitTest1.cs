using System;
using Xunit;
using Palindrome;

namespace PalindromeTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("frog", false)]
        [InlineData("w", true)]
        public void Palindrome(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
