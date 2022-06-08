// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace RemovePalindromicSequence;

public static class Program
{
    public static void Main(string[] args)
    {
        var palFinder = new Palindrome();
        var initialString = "aaabbaaa";
        var steps = palFinder.RemovePalindromeSequence(initialString, 0);
        Console.WriteLine($"Steps to remove palindromes from {initialString} :  {steps}");
    }
}