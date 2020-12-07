using System;
using System.Collections.Generic;

public class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter an number and I will PingPongify it!");
    string stringNumber = Console.ReadLine();
    int userNumber = int.Parse(stringNumber);

    for (int index = 1; index <= userNumber; index++)
    {
      if (index % 15 == 0)
      {
        Console.WriteLine("ping-pong");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (index % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else 
      {
        Console.WriteLine(index);
      }
    }
  }
}
