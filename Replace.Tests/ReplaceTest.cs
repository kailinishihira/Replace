using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Replace.Models;
using System;

namespace Replace.Tests 
{
  [TestClass]
  public class ReplacesTests
  {
    [TestMethod]
    public void  ReplaceWord_ChangeCatsToDogs_ILoveDogs()
    {
        Replaces testReplace = new Replaces("I love cats", "cats", "dogs");
        string expected = "I love dogs";
        string actual = testReplace.ReplaceWord();
        Assert.AreEqual(expected, actual);

    }
    [TestMethod]
     public void  ReplaceWord_ChangeCatToDog_ILoveDogs()
    {
        Replaces testReplace = new Replaces("I am walkinG my cat to the cathedral", "Cat", "Dog");
        string expected = "I am walking my dog to the doghedral";
        string actual = testReplace.ReplaceWord();
        Assert.AreEqual(expected, actual);

    }
  }
}