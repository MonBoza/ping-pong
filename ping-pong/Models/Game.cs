using System.Collections.Generic;

namespace PingPong.Models  // Namespace
{

  public class Game  // Class name
  {

    public int Number { get; set; }
    private static List<Game> _instances = new List<Game> { };
    public Game(int userNumber)
    {
      Number = userNumber;
    }

    public static List<int> CreateList(int userInput)
    {
      List<int> gameList = new List<int>();
      for (int index = 1; index <= userInput; index++)
      {
        gameList.Add(index);
     }
      return gameList;
    }
    public static List<string> ConvertList(List<int> gameList)
    {
      List<string> convertedList = new List<string>();
      foreach (int num in gameList)
      {
        string replacement = num.ToString();

        if (num % 3 == 0 && num % 5 == 0)
        {
          replacement = "ping-pong";

        }
        else if (num % 3 == 0)
        {
          replacement = "ping";

        }
        else if (num % 5 == 0)

         replacement = "pong";
      
       convertedList.Add(replacement);

  _instances.Add(new Game(num));
    }
    return convertedList;
    }

    public static List<Game> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}