using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using UnitTestProject.ExtensionMethods;
using UnitTestProject.Pages;
using UnitTestProject.Pages.BBC_Pages;
using UnitTestProject.Utilities;

namespace UnitTestProject.StepDefinitions
{
    [Binding]
    public class FormAndArtileLinksSteps
    {
        [Given(@"the BBC home page is open")]
        public void GivenTheBBCHomePageIsOpen()
        {
            //WebDriver.Driver.Url = "https://www.bbc.com"; // just to not violate the formed structure where Home page is being set
                                                            // in Hooks files i commented this statement up
        }
        
        [When(@"i go to News")]
        public void WhenIGoToNews()
        {
            new HomePage().GoToNewsPage();
        }
        
        [When(@"click on Entertainment & Arts tab")]
        public void WhenClickOnEntertainmentArtsTab()
        {
            new NewsPage().DismissSignInPopup().GoToEntertainmentAndArtsPage();
        }
        
        [When(@"click the first article")]
        public void WhenClickTheFirstArticle()
        {
            new EntertainmentPage().ClickFirstArtileLink();
        }
        
        [When(@"click Share")]
        public void WhenClickShare()
        {
            new ArticlePage().ClickShareButton();
        }
        
        [When(@"copy the Link")]
        public void WhenCopyTheLink()
        {
            ScenarioContext.Current.Add("expectedLink", WebDriver.Driver.Url);
            ScenarioContext.Current.Add("actualLink", new ArticlePage().LinkOnArticle);
        }
        
        [When(@"navigate the link")]
        public void WhenNavigateTheLink()
        {
            WebDriver.Driver.Navigate().GoToUrl(ScenarioContext.Current.Get<string>("actualLink"));
        }
        
        [When(@"click on Coronavirus tab")]
        public void WhenClickOnCoronavirusTab()
        {
            new NewsPage().DismissSignInPopup().GoToCoronavirusPage();
        }
        
        [When(@"click on Your Coronavirus Stories tab")]
        public void WhenClickOnYourCoronavirusStoriesTab()
        {
            new CoronavirusPage().GoToYourCoronavirusStoriesPage();
        }
        
        [When(@"go to How to Share with BBC News")]
        public void WhenGoToHowToShareWithBBCNews()
        {
            new YourCoronavirusStoryPage().GoToShareWithBbcNewsPage();
        }
        
        [When(@"fill in the information on the bottom")]
        public void WhenFillInTheInformationOnTheBottom(Table table)
        {
            new ShareWithBbcNewsPage().Form.FillForm(table.ToDictionary());
        }
        
        [When(@"click Submit")]
        public void WhenClickSubmit()
        {
            // My form gets submitted in previous step, that's why I am leaving this method empty
            // Hope it is OK
        }
        
        [Then(@"the same article is open")]
        public void ThenTheSameArticleIsOpen()
        {
            Assert.AreEqual(ScenarioContext.Current.Get<string>("expectedLink"), WebDriver.Driver.Url);
        }
        
        [Then(@"the story is not sent")]
        public void ThenTheStoryIsNotSent()
        {
            // Here, the way I verify that the form was not submitted is checking for whether error message(s) floated up
            var errorMessages = Wait.WaitForElementsToBeVisible(new ShareWithBbcNewsPage().ErrorMessages, 10);
            Assert.IsTrue(errorMessages.Any());
        }
    }
}