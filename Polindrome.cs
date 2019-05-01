using System;
using System.Linq;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        return word.ToLower().SequenceEqual(word.ToLower().Reverse());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}
