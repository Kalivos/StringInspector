using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector
{
    public class ArticleFromList : IArticleRetrieval
    {
        private List<string> articles = new List<string>() { "κόσμε", "aabbccdb" };

        public string GetNextArticle()
        {
            string text = String.Empty;

            if (articles.Count > 0)
            {
                text = articles[0];
                articles.RemoveAt(0);
            }

            return text;
        }
    }
}
