using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word to see its Scrabble score");
      string userInput = Console.ReadLine();
      Word word = new Word();
      Console.WriteLine(word.GetScore(userInput));
    }
  }
}