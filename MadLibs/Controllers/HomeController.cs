using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  { 
    [Route("/")]
    public ActionResult MadLibs() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string nounOne, string personOne, string verbOne, string nounTwo, string holiday, string colorOne, string adjectiveOne, string colorTwo, string adjectiveTwo, string verbTwo, string vegetable, string verbThree, string personTwo, string verbFour, string verbFive, string colorThree) 
    {
        StoryVariable myStoryVariable = new StoryVariable();
        myStoryVariable.NounOne = nounOne;
        myStoryVariable.PersonOne = personOne;
        myStoryVariable.VerbOne = verbOne;
        myStoryVariable.NounTwo = nounTwo;
        myStoryVariable.Holiday = holiday;
        myStoryVariable.ColorOne = colorOne;
        myStoryVariable.AdjectiveOne = adjectiveOne;
        myStoryVariable.ColorTwo = colorTwo;
        myStoryVariable.AdjectiveTwo = adjectiveTwo;
        myStoryVariable.VerbTwo = verbTwo;
        myStoryVariable.Vegetable = vegetable;
        myStoryVariable.VerbThree = verbThree;
        myStoryVariable.PersonTwo = personTwo;
        myStoryVariable.VerbFour = verbFour;
        myStoryVariable.VerbFive = verbFive;
        myStoryVariable.ColorThree = colorThree;
        return View(myStoryVariable);
    }
  }
}