﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using UnitTestProject.Pages.BBC_Pages;

namespace UnitTestProject.Pages.Lorem_Pages
{
    public class ResultPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='lipsum']/p")]
        private IList<IWebElement> paragraphs;

        public IEnumerable<string> Paragraphs
        {
            get
            {
                foreach (var paragraph in paragraphs)
                    yield return paragraph.Text;
            }
        }
    }
}