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

    public bool CheckForTranslation(string word)
    {
      if(word.Contains('3') || word.Contains('0') || word.Contains('1') || word.Contains('z'))
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
        else if(array[x] == 'o')
        {
          array[x] = '0';
        }
        else if(array[x] == 'I')
        {
          array[x] = '1';
        }
        else if(array[x] == 's' && x != 0)
        {
          array[x] = 'z';
        }
      }
      _leetWord = string.Join("", array);
      Console.WriteLine(_leetWord);
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
