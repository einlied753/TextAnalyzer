using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextAnalyzer.BL
{
    public class TextManager : ITextManager
    {
        //private readonly Encoding _encoding = Encoding.GetEncoding("windows-1251");
        private readonly Encoding _encoding = Encoding.UTF8;
        private string _webFilePath = "WebPageContent.txt";
        private string _statisticFilePath = "StatisticText.txt";

        public string ConvertPageContentToString(string url)
        {
            WebClient client = new WebClient();
            //_encoding = Encoding.Default;
            client.Encoding = _encoding;
            return client.DownloadString(url);
        }

        public void DownloadPageContentToFile(string url)
        {
            SaveTextToFile(ConvertPageContentToString(url), _webFilePath);
        }

        public void SaveStatisticToFile(string text)
        {
            SaveTextToFile(text, _statisticFilePath);
        }

        public void SaveTextToFile(string filePath, string text)
        {
            SaveTextToFile(text, filePath, _encoding);
        }

        public void SaveTextToFile(string filePath, string text, Encoding encoding)
        {
            File.WriteAllText(filePath, text, encoding);
        }

        public bool isFileExist(string filePath)
        {
            return File.Exists(filePath);
        }

        public Dictionary<string, int> GetWordStatisticFromWebPage(string url)
        {
            return GetWordStatistic(ConvertPageContentToString(url));
        }

        public Dictionary<string, int> GetWordStatistic(string text)
        {
            IEnumerable<string> words = text.Split(' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t', '<', '>').Where(x => !string.IsNullOrEmpty(x));
            IEnumerable<string> uniqueWords = words.Distinct().Select(x => x.ToLower().Trim());
            Dictionary<string, int> wordStatistic = new Dictionary<string, int>();

            foreach (string word in uniqueWords)
            {
                if (Regex.IsMatch(word, @"[а-яА-Я]+", RegexOptions.IgnoreCase))
                {
                    wordStatistic[word] = words.Count(x => x.ToLower().Equals(word));
                }
            }

            return wordStatistic;
        }

        public string GetWordStatisticStringFromWebPage(string url)
        {
            return GetWordStatisticString(GetWordStatisticFromWebPage(url));
        }

        public string GetWordStatisticString (Dictionary<string, int> words)
        {
            string wordStatisticString = "";

            foreach (KeyValuePair<string, int> word in words)
            {
                wordStatisticString += word.Key + " - " + word.Value + '\n' + " ";
            }

            return wordStatisticString;
        }


    }
}
