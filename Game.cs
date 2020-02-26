using System;

public class Game
{
  public int MinNumber;
  public int MaxNumber;

  public bool PlayGame;

  public Game(int minNumber, int maxNumber, bool playGame)
  {
    MinNumber = minNumber;
    MaxNumber = maxNumber;
    PlayGame = playGame;
  }



}


public class Program
{

public static int RandomNumber(int minNumber, int maxNumber)
{
  var rand = new Random();
  int index = rand.Next(minNumber, maxNumber);
  return index;
}
  

  public static void GuessNumber (int index)
  {
    Console.WriteLine("Is your number higher or lower than " + index + "? (Higher/Lower/Correct");
      string answer = Console.ReadLine();
     
    if( answer == "Higher")
    {
      Game newGame = new Game(index, 101, true);
      int randomNumber = RandomNumber(newGame.MinNumber, newGame.MaxNumber);
      GuessNumber(randomNumber);

    }
    else if ( answer == "Lower")
    {
      Game newGame = new Game(0, index, true);
      int randomNumber = RandomNumber(newGame.MinNumber, newGame.MaxNumber);
      GuessNumber(randomNumber);
    }
    else
    {
      Console.WriteLine( "Great! I guessed your number.");
     
    }
  }

  public static void Main()
  {
   
    Console.WriteLine("Would you like to play the highger/lower game?(Yes/No)");
    string playGame = Console.ReadLine();

    if (playGame == "Yes")
    {
      Console.WriteLine("Pick a number between 1-100"); 
      Game newGame = new Game(0, 101, true);
      int randomNumber = RandomNumber(newGame.MinNumber, newGame.MaxNumber);
  
      GuessNumber(randomNumber);
    }
    else
    {
      Console.WriteLine("Goodbye.");
    }
  }
}
