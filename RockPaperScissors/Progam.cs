using System;
using System.Collections.Generic;
using RockPaperScissors.Models;

namespace RockPaperScissors
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Let's play rock, paper, scissors");
      Console.WriteLine("Player one choose your fighter (rock, paper or scissors)");
      string word1 = Console.ReadLine().ToLower();
      Console.WriteLine("Player two choose your fighter (rock, paper or scissors)");
      string word2 = Console.ReadLine().ToLower();
      string winner = Rochambeau.CheckResult(word1, word2);
      Console.WriteLine(winner);
    }
  }
}
