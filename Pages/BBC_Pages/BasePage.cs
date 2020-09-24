using System;
using UnitTestProject.Utilities;
using SeleniumExtras.PageObjects;

namespace UnitTestProject.Pages.BBC_Pages
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(WebDriver.Driver, this);
        }
    }
}