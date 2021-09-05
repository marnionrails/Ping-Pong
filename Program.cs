using System;
using System.Collections.Generic;
using System.Linq;
using PingPong.Models;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Game game1 = new Game("Marni");
      Game game2 = new Game("Emily");
      Game game3 = new Game("Rachel");

      List<Game> People = new List<Game>(){game1, game2, game3};
      List<Game> Inputs = new List<Game>(0);

      foreach (Game item in People) 
      {
        Console.WriteLine(item.UserName);
      }

      IEnumerable<Game> allGames = new[] { game1, game2, game3};

      List<IEnumerable<Game>> listOfLists = new List<IEnumerable<Game>>();

      for (int i = 0; i < allGames.Count(); i += 4)
      {                
        listOfLists.Add(allGames.Skip(i).Take(4)); 
      }     
      
      game1.Number = 3;
      game1.Output();
    }
    
  }
}

