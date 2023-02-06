using System;

using Game.Models;

namespace GamePlay
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Player one input 'rock', 'paper', or 'scissors'.");
      string player1 = Console.ReadLine();
      Console.WriteLine("Player two input 'rock', 'paper', or 'scissors'.");
      string player2 = Console.ReadLine();
      
      

      if ((player1 == "rock" && player2 == "scissors") || (player1 == "scissors" && player2 == "paper") || (player1 == "paper" && player2 == "rock")) {
        Console.WriteLine("Player 1 wins!");
      } else if (player1 == player2) {
        Console.WriteLine("womp womp... it's a TIE!");
      }else 
      {
        Console.WriteLine("Player 2 wins!");
      }

    }
  }
}