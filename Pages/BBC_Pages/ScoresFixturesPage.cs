﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using UnitTestProject.Utilities;

namespace UnitTestProject.Pages.BBC_Pages
{
    class ScoresFixturesPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='search']")]
        private IWebElement searchBar;

        public void SearchFor(string championship)
        {
            searchBar.SendKeys(championship + Keys.ArrowDown + Keys.Enter);
            Wait.WaitForPageReadyState(10);
        }
    }
}