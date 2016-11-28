using Xunit;
using System.Collections.Generic;
using System;


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

    [Fact]
    public void checkArray()
    {
      LeetSpeak leetWord = new LeetSpeak();
      leetWord.SetUserWord();
      leetWord.WordToArray(leetWord.GetUserWord());

      Assert.Equal(true, leetWord.CheckArray());
    }

    [Fact]
    public void checkTranslation_toLeet()
    {
      LeetSpeak leetWord = new LeetSpeak();
      leetWord.SetUserWord();
      leetWord.WordToArray(leetWord.GetUserWord());
      leetWord.LeetTranslator(leetWord.GetUserArray());

      Assert.Equal(true, leetWord.CheckForTranslation(leetWord.GetLeetWord()));
    }
  }
}
