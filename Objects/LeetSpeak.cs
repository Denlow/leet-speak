using System.Collections.Generic;
using System;

namespace LeetSpeak
{
  public class LeetSpeak
  {
    private string _userWord;
    private string _leetWord;
    private char[] _userWordArray;


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

    public bool CheckArray()
    {
      if(_userWordArray.Length == 0)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    public char[] WordToArray(string word)
    {
      _userWordArray = word.ToCharArray();
      return _userWordArray;
    }


    public string GetUserWord()
    {
      return _userWord;
    }

    public void SetUserWord()
    {
      _userWord = Console.ReadLine();
    }

    public char[] GetUserArray()
    {
      return _userWordArray;
    }
  }
}
