namespace RemovePalindromicSequence;

public class Palindrome
{
    public int RemovePalindromeSequence(string inputString, int minSteps)
    {
        return IsPalindrome(inputString) ? 1 : GetUniqueCharacters(inputString);
    }

    private bool IsPalindrome(string stringToTest)
    {
        return stringToTest.SequenceEqual(stringToTest.Reverse());
    }

    private int GetUniqueCharacters(string stringToTest)
    {
        return stringToTest.Distinct().Count();
    }
}