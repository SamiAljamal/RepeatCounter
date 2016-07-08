using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RepeatCount.Objects
{
  public class RepeatCounter
  {

    public int CountRepeats(string word, string phrase)
    {
      int result = 0;
      string searchWord= word.ToLower().Trim();

    string[] splitPhrase = phrase.ToLower().Split(' ','.','!',';',':','/','|','|','?');
      foreach (string occurance in splitPhrase)
      {
        if(searchWord == occurance)
        {
          result ++;
        }
      }
      return result;
    }
  }
}
