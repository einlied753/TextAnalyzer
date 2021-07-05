using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzer.BL;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public class TextAnalyzerController
    {
        private ITextManager _textManager;
        private ITextAnalyzerForm _textAnalyzerForm;

        public TextAnalyzerController(ITextManager textManager, ITextAnalyzerForm textAnalyzerForm)
        {
            _textManager = textManager;
            _textAnalyzerForm = textAnalyzerForm;
            _textAnalyzerForm.textAnalizerClick += _textAnalyzerForm_textAnalizerClick;
            _textAnalyzerForm.savePageClick += _textAnalyzerForm_savePageClick;
            _textAnalyzerForm.saveStatisticClick += _textAnalyzerForm_saveStatisticClick;
        }

        private void _textAnalyzerForm_textAnalizerClick(object sender, EventArgs e)
        {
            try
            {
                _textAnalyzerForm.StatisticText = _textManager.GetWordStatisticStringFromWebPage(_textAnalyzerForm.Url).Replace("\n", Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Не удалось вывести статистику", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textAnalyzerForm_savePageClick(object sender, EventArgs e)
        {
            try
            {
                _textManager.DownloadPageContentToFile(_textAnalyzerForm.Url);
                MessageBox.Show("Текст веб-страницы сохранен в файл", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить текст веб-страницы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _textAnalyzerForm_saveStatisticClick(object sender, EventArgs e)
        {
            try
            {
                string wordStatistic = _textManager.GetWordStatisticStringFromWebPage(_textAnalyzerForm.Url);
                _textManager.SaveStatisticToFile(wordStatistic);
                MessageBox.Show("Текст статистики сохранен в файл", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить статистику", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
