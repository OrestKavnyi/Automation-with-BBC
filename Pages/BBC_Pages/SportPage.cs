using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using UnitTestProject.Utilities;

namespace UnitTestProject.Pages.BBC_Pages
{
    class SportPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'sport-navigation')]/a[@* = 'Football']")]
        private IWebElement footballLink;

        public void GoToFootballPage()
        {
            footballLink.Click();
        }

        public SportPage DismissSignInPopup()
        {
            Wait.WaitForElementsToBeVisible(By.XPath("//div[@id='sign_in']"), 20);
            WebDriver.Driver.FindElement(By.XPath("//button[@class='sign_in-exit']")).Click();
            return this;
        }
    }
}
