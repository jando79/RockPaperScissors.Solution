using System;

namespace RockPaperScissors.Models
{
  public class Rochambeau
  {
    public static string CheckResult(string player1Choice, string player2Choice)
    {
      if (player1Choice == player2Choice)
      {
        return "draw";
      }
      else if (player1Choice == "rock" && player2Choice == "scissors")
      {
        return "player1 wins";
      }
      else if (player2Choice == "rock" && player1Choice == "scissors")
      {
        return "player2 wins";
      }
      else if (player1Choice == "scissors" && player2Choice == "paper")
      {
        return "player1 wins";
      }
      else if (player2Choice == "scissors" && player1Choice == "paper")
      {
        return "player2 wins";
      }
      else if (player1Choice == "paper" && player2Choice == "rock")
      {
        return "player1 wins";
      }
      else if (player2Choice == "paper" && player1Choice == "rock")
      {
        return "player2 wins";
      }
      return "error";
    }
  }
}
//run dotnet run in this project directory