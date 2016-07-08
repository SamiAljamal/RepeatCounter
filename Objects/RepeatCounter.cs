using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {

    public int CountRepeats(string word, string phrase)
    {
      int result = 0;
      List<string> splitPhrase = new List<string>(phrase.Split(" ".ToCharArray()));
      foreach (string occurance in splitPhrase)
      {
        if(word == occurance)
        {
          result ++;
        }
      }
      return result;
    }
  }
}
