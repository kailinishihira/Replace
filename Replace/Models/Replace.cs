using System;
using System.Collections.Generic;

namespace Replace.Models
{
  public class Replaces
  {
    private  string _inputString;
    private string _wordToReplace;
    private static string _replacementWord;
    // private static List<string> _winnerList = new List<string> {};

    public Replaces (string inputString, string wordToReplace, string replacementWord)
    {
     _inputString = inputString;
     _wordToReplace = wordToReplace;
     _replacementWord = replacementWord;
    }
    public string ReplaceWord()
    {
        string inputStringLower = _inputString.ToLower();
        string wordToReplaceLower = _wordToReplace.ToLower();
        string replacementWordLower = _replacementWord.ToLower();
        string result =  inputStringLower.Replace(wordToReplaceLower, replacementWordLower);
        string capResult = char.ToUpper(result[0]) + result.Substring(1);
        return capResult;
    }
  }
}