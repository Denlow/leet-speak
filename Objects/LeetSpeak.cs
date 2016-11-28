using System.Collections.Generic;
using System;

namespace LeetSpeak
{
  public class LeetSpeak
  {
    private string _userWord;
    private string _leetWord;


    public bool CheckUserWord()
    {
      if(String.IsNullOrEmpty(_userWord))
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public void SetUserWord()
    {
      _userWord = Console.ReadLine();
    }

  }
}
