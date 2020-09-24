using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UnitTestProject.Pages.BBC_Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@href='/news']")]
        private IWebElement newsLink;

        [FindsBy(How = How.XPath, Using = "//a[@href='/sport']")]
        private IWebElement sportLink;

        [FindsBy(How = How.XPath, Using = "//input[@id='orb-search-q']")]
        private IWebElement searchBar;

        public void GoToNewsPage()
        {
            newsLink.Click();
        }

        public void GoToSportPage()
        {
            sportLink.Click();
        }
        public void SearchFor(string keyword)
        {
            searchBar.SendKeys(keyword + Keys.Enter);
        }
    }
}