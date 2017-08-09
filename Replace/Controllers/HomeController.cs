using Microsoft.AspNetCore.Mvc;
using Replace.Models;
using System.Collections.Generic;
using System;

namespace Replace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/")]
        public ActionResult IndexResults()
        {
            string userString = (Request.Form["user-string"]);
            string chosenWord = (Request.Form["chosen-word"]);
            string replacementWord = (Request.Form["replacement-word"]);
            Replaces newReplace = new Replaces (userString, chosenWord, replacementWord);
            string replaceOutput = newReplace.ReplaceWord();
            return View("Index", replaceOutput);
        }
    }
}