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
  }
}
