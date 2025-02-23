namespace PalindromeTest;

using Palindrome;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Palindrome.IsPalindrome("abba"));
    }
}
