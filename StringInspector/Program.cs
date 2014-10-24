using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInspector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            ArticleFromList article = new ArticleFromList();

            Inspector inspect = null;
            string next = String.Empty;

            do
            {
                next = article.GetNextArticle();
                inspect = new Inspector(next);
                Console.WriteLine("Most used character: " + inspect.GetMostUsed());
            }
            while (next.Length > 0);

            Console.ReadKey();
        }
    }
}
