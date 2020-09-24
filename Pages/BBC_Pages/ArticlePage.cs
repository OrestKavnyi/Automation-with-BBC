using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using UnitTestProject.Utilities;

namespace UnitTestProject.Pages.BBC_Pages
{
    class ArticlePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'share-button')]")]
        private IWebElement shareButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'share-link')]")]
        private IWebElement linkOnArticle;
        public string LinkOnArticle
        {
            get { return linkOnArticle.Text; }
        }
        public ArticlePage()
        {
            Wait.WaitForPageReadyState(10);
        }
        public void ClickShareButton()
        {
            shareButton.Click();
        }
    }
}