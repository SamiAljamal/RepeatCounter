using Nancy;
using System.Collections.Generic;
using System;
using RepeatCounter.Objects;


namespace RepeatCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View["form.cshtml"];
      };
    }
  }
}
