using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzer.BL
{
    public interface ITextManager
    {
        /// <summary>
        /// Преобразует контент веб-страницы в текст
        /// </summary>
        /// <param name="url">адрес веб-страницы</param>
        /// <returns></returns>
        string ConvertPageContentToString(string url);

        /// <summary>
        /// Скачивает контент веб-страницы в файл
        /// </summary>
        /// <param name="url">адрес веб-страницы</param>
        void DownloadPageContentToFile(string url);

        /// <summary>
        /// Сохраняет статистику в файл
        /// </summary>
        /// <param name="text"></param>
        void SaveStatisticToFile(string text);

        void SaveTextToFile(string filePath, string text);

        void SaveTextToFile(string filePath, string text, Encoding encoding);

        /// <summary>
        /// Проверяет, существует ли занный путь к файлу
        /// </summary>
        /// <param name="filePath">путь к файлу</param>
        /// <returns></returns>
        bool isFileExist(string filePath);

        /// <summary>
        /// Возвращает список уникальных слов и количество их повторения с веб-страницы
        /// </summary>
        /// <param name="url">адрес веб-страницы</param>
        /// <returns></returns>
        Dictionary<string, int> GetWordStatisticFromWebPage(string url);

        /// <summary>
        /// Возвращает список уникальных слов и количество их повторения в тексте
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        Dictionary<string, int> GetWordStatistic(string text);

        /// <summary>
        /// Возвращает текстовую строку списка уникальных слов и количество их повторения с веб-страницы
        /// </summary>
        /// <param name="url">адрес веб-страницы</param>
        /// <returns></returns>
        string GetWordStatisticStringFromWebPage(string url);

        /// <summary>
        /// Преобразует список уникальных слов в текстовую строку
        /// </summary>
        /// <param name="words">список уникальных слов</param>
        /// <returns></returns>
        string GetWordStatisticString(Dictionary<string, int> words);
    }
}
