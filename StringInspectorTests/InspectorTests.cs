using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringInspector;

namespace StringInspectorTests
{
    [TestClass]
    public class InspectorTests
    {
        [TestMethod]
        public void TestAppend()
        {
            // arrange
            ArticleFromFile article = new ArticleFromFile("./SampleArticles");
            Inspector inspect = new Inspector(String.Empty);

            // act
            string next = article.GetNextArticle();

            while (!String.IsNullOrWhiteSpace(next))
            {
                inspect.Append(next);
                next = article.GetNextArticle();
            }

            // assert
            Assert.AreEqual('e', inspect.GetMostUsed());
        }

        [TestMethod]
        public void TestGetMostUsed()
        {
            // arrange
            ArticleFromFile article = new ArticleFromFile("./SampleArticles");
            Inspector inspect = null;

            // act
            string next = article.GetNextArticle();

            while (!String.IsNullOrWhiteSpace(next))
            {
                inspect = new Inspector(next);
                next = article.GetNextArticle();
            }

            // assert
            Assert.AreEqual('e', inspect.GetMostUsed());
        }

        [TestMethod]
        public void TestGetNumberTimesUsed()
        {
            // arrange
            ArticleFromFile article = new ArticleFromFile("./SampleArticles");
            Inspector inspect = new Inspector(String.Empty);

            // act
            string next = article.GetNextArticle();

            while (!String.IsNullOrWhiteSpace(next))
            {
                inspect.Append(next);
                next = article.GetNextArticle();
            }

            // assert
            Assert.AreEqual(1516, inspect.GetNumberTimesUsed());
        }

        [TestMethod]
        public void TestGetNumberTimesUsedOverload()
        {
            // arrange
            ArticleFromFile article = new ArticleFromFile("./SampleArticles");
            Inspector inspect = new Inspector(String.Empty);

            // act
            string next = article.GetNextArticle();

            while (!String.IsNullOrWhiteSpace(next))
            {
                inspect.Append(next);
                next = article.GetNextArticle();
            }

            // assert
            Assert.AreEqual(1055, inspect.GetNumberTimesUsed('a'));
        }
    }
}
