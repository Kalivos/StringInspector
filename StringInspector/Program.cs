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
            string next = article.GetNextArticle();

            while (!String.IsNullOrWhiteSpace(next))
            {
                inspect = new Inspector(next);
                Console.WriteLine("Most used character: " + inspect.GetMostUsed());

                next = article.GetNextArticle();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
