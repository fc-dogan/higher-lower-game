using System;
using System.Collections.Generic;

public class Program
{

  

  public int GuessNumber (int index)
  {
    Console.WriteLine("Is your number higher or lower than " + index + "? (Higher/Lower/Correct");
      string answer = Console.ReadLine();
      var rand = new Random();
    if( answer == "Higher")
    {
      index = rand.Next(index, 101);
      return index;

    }
    else if ( answer == "Lower")
    {
      index = rand.Next(index);
      return index;
    }
    else
    {
      // string response = "Great! I guessed your number.";
      return  -1;
    }
  }

  public static void Main()
  {
    Console.WriteLine("Would you like to play the highger/lower game?(Yes/No)");
    string playGame = Console.ReadLine();

    if (playGame == "Yes")
    {
      Console.WriteLine("Pick a number between 1-100");
      var rand = new Random();
      int index = rand.Next(101);

      GuessNumber(index);
  
      // Console.WriteLine("Is your number higher or lower than " + index + "? (Higher/Lower/Correct");
      // string answer = Console.ReadLine();
      
      //   if( answer == "Higher")
      //   {
      //     index = rand.Next(index, 101);
      //     return index;

      //   }
      //   else if ( answer == "Lower")
      //   {
      //     index = rand.Next(index);
      //     return index;
      //   }
      //   else
      //   {
      //     string response = "Great! I guessed your number.";
      //     return  response;
      //   }
          
    }
    else
    {
      Console.WriteLine("Goodbye.");
    }
  }
}