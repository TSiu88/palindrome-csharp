using System;
using System.Text;

namespace Palindrome {
  public class Word {
    public string WordString { get; set; }
    public Word(string word) {
      WordString = word.ToLower();
    }

    public void DeterminePalindrome() {
      char[] wordCharacters = WordString.ToCharArray();
      Array.Reverse(wordCharacters);
      StringBuilder sb = new StringBuilder();
      sb.Append(wordCharacters);
      if(WordString == sb.ToString()) {
        Console.WriteLine("Word is a palindrome");
      } else {
        Console.WriteLine("Word is not a palindrome");
      }
    }
  }
}