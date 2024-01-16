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