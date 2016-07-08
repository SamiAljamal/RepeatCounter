using Nancy;
using System.Collections.Generic;
using System;
using RepeatCount.Objects;


namespace RepeatCount
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View["form.cshtml"];
      };
      Post["/wordsearch/created"]=_=>{
        string wordsearch = Request.Form["word"];
        string phrase = Request.Form["phrase"];
        RepeatCounter newCount = new RepeatCounter();
        int CountResult = newCount.CountRepeats(wordsearch,phrase);
        return View["results.cshtml", CountResult];

      };
    }
  }
}
