using Xunit;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void isWord_NotEmpty()
    {
      LeetSpeak leetWord = new LeetSpeak();
      leetWord.SetUserWord();
      Assert.Equal(true, leetWord.CheckUserWord());
    }
  }
}
