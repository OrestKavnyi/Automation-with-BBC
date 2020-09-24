using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestProject.PageElements;
using UnitTestProject.Utilities;

namespace UnitTestProject.Pages.BBC_Pages
{
    class MatchInfoPage : BasePage
    {
        public MatchInfo GetMatchInfo()
        {
            IList<IWebElement> teams = WebDriver.Driver.FindElements(By.XPath(
                                       "//span[contains(@class,'team')]//span[contains(@class,'full-team-name')]"));
            IList<IWebElement> score = WebDriver.Driver.FindElements(By.XPath(
                                       "//span[contains(@class,'team')]//span[contains(@class,'number')]"));

            return new MatchInfo(teams.First().Text, teams.Last().Text, int.Parse(score.First().Text), int.Parse(score.Last().Text));   
        }
    }
}