using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector
{
    interface IArticleRetrieval
    {
        /// <summary>
        /// Stub for fetching the next article to pass into the parser
        /// </summary>
        /// <returns>Text of an Article</returns>
        string GetNextArticle();
    }
}
