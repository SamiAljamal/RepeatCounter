using Xunit;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RepeatCounter.Objects
{
  public class RepeatCounter
  {

    public int CountRepeats(string word, string phrase)
    {
      int result = 0;
      if (word == phrase )
      {
        result =1;
      }
      return result;
    }
  }
}
