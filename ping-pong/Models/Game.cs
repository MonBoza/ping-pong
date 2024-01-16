namespace PingPong.Models  // Namespace
{

  public class Game  // Class name
  {
     
    public int Number { get; set;}
    // private static List<Game> _instances = new List<Game> {};
    public Game(int userNumber)
    {
      Number = userNumber;

    }
  }
}