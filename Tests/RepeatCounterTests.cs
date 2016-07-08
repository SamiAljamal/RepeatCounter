using Xunit;

namespace RepeatCounter.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeateCounter_LetterE_1()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.Equal(1, newCounter.CountRepeats("e","e"));
    }

    [Fact]
    public void RepeateCounter_Word_1()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.Equal(1, newCounter.CountRepeats("word","word"));
    }

    [Fact]
    public void RepeateCounter_Phrase_2()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.Equal(3, newCounter.CountRepeats("word","word for word for word"));
    }
    [Fact]
    public void RepeateCounter_Phrase_5()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.Equal(5, newCounter.CountRepeats("word","word for word for word will always be a word for a word"));
    }
    [Fact]
    public void RepeateCounter_Phrasecontainspunctuation_5()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.Equal(5, newCounter.CountRepeats("word","word! for word! for word? will always be a word for a word."));
    }

    [Fact]
    public void RepeateCounter_SearchWordContainsWhiteSpace_5()
    {
      RepeatCounter newCounter = new RepeatCounter();
      Assert.Equal(5, newCounter.CountRepeats(" woRd ","Word! for word! for word? will always be a word for a word."));
    }
  }
}
