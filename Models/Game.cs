using System;
using System.Collections.Generic;

namespace PingPong.Models
{
  public class Game
  {
    public string UserName {get; set;}
    public int Number {get; set;}
    

  public static string Ready(string noise)
  {
    return "The players say " + noise;
  }
    public Game(string userName)
    {
      UserName = userName;
    }

  public void Output()
  {
    for(int num = 0; num <= Number; num++) 
    {
      if(num % 3 == 0 && num % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if(num % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if(num % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(num);
      }
    }
  }
 }
}