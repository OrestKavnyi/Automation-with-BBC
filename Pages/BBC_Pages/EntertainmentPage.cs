using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using UnitTestProject.Utilities;

namespace UnitTestProject.Pages.BBC_Pages
{
    class EntertainmentPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@aria-label='Top Stories']/div[contains(@class,'News')]//a[contains(@class,'heading')]")]
        private IWebElement firstArticleLink;
        public EntertainmentPage()
        {
            Wait.WaitForPageReadyState(10);
        }
        public void ClickFirstArtileLink()
        {
            firstArticleLink.Click();
        }
    }
}