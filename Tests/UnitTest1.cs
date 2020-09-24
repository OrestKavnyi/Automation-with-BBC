/*using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {
        private static readonly string EXPECTED_HEADLINE_ARTICLE_TITLE = "Australian reporters leave China 'amid standoff'";
        [TestMethod]
        public void CheckHeadlineArticleTitle()
        {
            new HomePage(Driver).GoToNewsPage();
            new NewsPage(Driver).DismissSignInPopup();

            Assert.AreEqual(EXPECTED_HEADLINE_ARTICLE_TITLE, new NewsPage(Driver).HeadlineArticleTitle);
        }


        private static readonly List<string> EXPECTED_SECONDARY_ARTICLES_TITLES = new List<string> { "Australian reporters leave China 'amid standoff'",
                                                                                                     "UK virus increase 'concerning', says minister",
                                                                                                     "Belarus opposition  leader 'detained at border'" };
        [TestMethod]
        public void CheckSecondaryArticlesTitles()
        {
            new HomePage(Driver).GoToNewsPage();
            new NewsPage(Driver).DismissSignInPopup();

            List<string> secondaryArticlesTitles = new NewsPage(Driver).SecondaryArticlesTitles;
            for (int i = 0; i < EXPECTED_SECONDARY_ARTICLES_TITLES.Count; i++)
                Assert.AreEqual(EXPECTED_SECONDARY_ARTICLES_TITLES[i], secondaryArticlesTitles[i]);
        }


        private static readonly string EXPECTED_FIRST_FOUND_ARTICLE_TITLE = "Ambulance Australia";
        [TestMethod]
        public void CheckThatSearchResultContainsKeyword()
        {
            new HomePage(Driver).GoToNewsPage();
            new NewsPage(Driver).DismissSignInPopup();
            new HomePage(Driver).SearchFor(new NewsPage(Driver).HeadlineArticleCategory);

            Assert.AreEqual(EXPECTED_FIRST_FOUND_ARTICLE_TITLE, new SearchResultPage(Driver).FirstArticleTitle);
        }


        private readonly Dictionary<string, string> invalidNameSetOfData = new Dictionary<string, string>()
        {
            ["Tell us your story. "] = "sb's story",
            ["Name"] = "     ",
            ["Please don't publish my name"] = null,
            ["I am over 16 years old"] = null,
            ["Terms of Service"] = null,
        };
        [TestMethod]
        public void CheckSubmitQuestionWithInvalidName()
        {
            new BusinessLogicLayer(Driver).SubmitQuestionToBbcWith(invalidNameSetOfData);
            IList<IWebElement> errMessages = new BasePage(Driver).WaitForElementsToBeVisible(
                                                                  new ShareWithBbcNewsPage(Driver).GetErrorMessages(), 10);

            Assert.IsTrue(errMessages.Any());
        }


        private readonly Dictionary<string, string> storyNotProvidedSetOfData = new Dictionary<string, string>()
        {
            ["Name"] = "Matt",
            ["Please don't publish my name"] = null,
            ["I am over 16 years old"] = null,
            ["Terms of Service"] = null,
        };
        [TestMethod]
        public void CheckSubmitQuestionWithStoryFieldLeftEmpty()
        {
            new BusinessLogicLayer(Driver).SubmitQuestionToBbcWith(storyNotProvidedSetOfData);
            IList<IWebElement> errMessages = new BasePage(Driver).WaitForElementsToBeVisible(
                                                                  new ShareWithBbcNewsPage(Driver).GetErrorMessages(), 10);

            Assert.IsTrue(errMessages.Any());
        }


        private readonly Dictionary<string, string> termsNotAcceptedSetOfData = new Dictionary<string, string>()
        {
            ["Tell us your story. "] = "Matt's story",
            ["Name"] = "Matt",
            ["I am over 16 years old"] = null,
        };
        [TestMethod]
        public void CheckSubmitQuestionWithNotAcceptedTerms()
        {
            new BusinessLogicLayer(Driver).SubmitQuestionToBbcWith(termsNotAcceptedSetOfData);
            IList<IWebElement> errMessages = new BasePage(Driver).WaitForElementsToBeVisible(
                                                                  new ShareWithBbcNewsPage(Driver).GetErrorMessages(), 10);

            Assert.IsTrue(errMessages.Any());
        }


        private readonly Dictionary<string, string> ageNotConfirmedSetOfData = new Dictionary<string, string>()
        {
            ["Tell us your story. "] = "Matt's story",
            ["Name"] = "Matt",
            ["Terms of Service"] = null,
        };
        [TestMethod]
        public void CheckSubmitQuestionWithNotConfirmedAge()
        {
            new BusinessLogicLayer(Driver).SubmitQuestionToBbcWith(ageNotConfirmedSetOfData);
            IList<IWebElement> errMessages = new BasePage(Driver).WaitForElementsToBeVisible(
                                                                  new ShareWithBbcNewsPage(Driver).GetErrorMessages(), 10);

            Assert.IsTrue(errMessages.Any());
        }
    }
}*/