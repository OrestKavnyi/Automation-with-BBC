using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace UnitTestProject.Pages.BBC_Pages
{
    public class YourCoronavirusStoryPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//a[h3='How to share with BBC News']")]
        private readonly IWebElement shareWithBbcNewsLink;

        public void GoToShareWithBbcNewsPage()
        {
            shareWithBbcNewsLink.Click();
        }
    }
}