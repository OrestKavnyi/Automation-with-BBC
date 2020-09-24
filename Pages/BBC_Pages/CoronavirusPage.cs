using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using UnitTestProject.Utilities;

namespace UnitTestProject.Pages.BBC_Pages
{
    public class CoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'menuitem-container')]//span[text()='Your Coronavirus Stories']")]
        private readonly IWebElement yourCoronavirusStoriesLink;
        public void GoToYourCoronavirusStoriesPage()
        {
            yourCoronavirusStoriesLink.Click();
        }
    }
}