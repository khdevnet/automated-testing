using System;
using System.Text;

namespace Wordpress.Automation.Framework.TestData
{
    public class ArticleDataGenerator
    {
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static string CreateRandomString()
        {
            lock (syncLock)
            {
                var s = new StringBuilder();
                var cycles = random.Next(5 + 1);
                for (int i = 0; i < cycles; i++)
                {
                    s.Append(Words[random.Next(Words.Length)]);
                    s.Append(" ");
                    s.Append(Articles[random.Next(Articles.Length)]);
                    s.Append(" ");
                    s.Append(Words[random.Next(Words.Length)]);
                    s.Append(" ");
                }
                return s.ToString();
            }
        }

        private static string[] Words = new[]
                                     {
                                         "boy", "cat", "dog", "rabbit", "baseball", "throw", "find", "scary", "code",
                                         "mustard"
                                     };

        private static string[] Articles = new[]
                                     {
                                         "the", "an", "and", "a", "of", "to", "it", "as"
                                     };
    }
}
