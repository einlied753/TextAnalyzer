using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzer
{

    public partial class TextAnalyzerForm : Form, ITextAnalyzerForm
    {
        public TextAnalyzerForm()
        {
            InitializeComponent();
            textAnalyzerButton.Click += textAnalyzerButton_Click;
            savePageButton.Click += savePageButton_Click;
            saveStatisticButton.Click += saveStatisticButton_Click;
        }

        public string Url { get { return urlTextBox.Text; } }

        public string StatisticText { get { return statisticTextBox.Text; } set { statisticTextBox.Text = value; } }

        public event EventHandler textAnalizerClick;

        public event EventHandler savePageClick;

        public event EventHandler saveStatisticClick;


        private void textAnalyzerButton_Click(object sender, EventArgs e)
        {
            textAnalizerClick?.Invoke(this, EventArgs.Empty);
        }

        private void savePageButton_Click(object sender, EventArgs e)
        {
            savePageClick?.Invoke(this, EventArgs.Empty);
        }

        private void saveStatisticButton_Click(object sender, EventArgs e)
        {
            saveStatisticClick?.Invoke(this, EventArgs.Empty);
        } 
    }
}
