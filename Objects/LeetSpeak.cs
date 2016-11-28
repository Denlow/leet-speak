using System.Collections.Generic;
using System.Linq;
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

    public bool CheckForE_To_3(string word)
    {
      if(word.Contains('3'))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public char[] WordToArray(string word)
    {
      _userWordArray = word.ToCharArray();
      return _userWordArray;
    }

    public string LeetTranslator(char[] array)
    {
      for(int x = 0; x < array.Length; x++)
      {
        if(array[x] == 'e')
        {
          array[x] = '3';
        }
        _leetWord = string.Join("", array);
      }
      return _leetWord;
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

    public string GetLeetWord()
    {
      return _leetWord;
    }
  }
}
