using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector
{
    public class ArticleFromFile : IArticleRetrieval
    {
        private List<string> articles = new List<string>();

        public ArticleFromFile(string directory)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                foreach (FileInfo file in di.EnumerateFiles("*.txt"))
                {
                    using (StreamReader sr = file.OpenText())
                    {
                        StringBuilder s = new StringBuilder();
                        string tmp = String.Empty;

                        while ((tmp = sr.ReadLine()) != null)
                        {
                            s.Append(tmp);
                        }

                        articles.Add(s.ToString());
                    }
                }
            }
            /*
             * I'm going to be lazy here...
             * In real world application you would want to log the exception & not catch blanket exceptions
            */
            catch (Exception e)
            {
                throw e;
            }
        }

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
