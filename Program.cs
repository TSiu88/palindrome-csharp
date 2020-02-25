using System;
using Palindrome;
  public class Program {
    static void Main()
    {
     Console.WriteLine("Enter a word to determine if it's a palindrome.");
     string input = Console.ReadLine();
     Word w = new Word(input);
     w.DeterminePalindrome();
     Console.ReadLine();
    }
  }
