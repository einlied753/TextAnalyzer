namespace TextAnalyzer
{
    partial class TextAnalyzerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.textAnalyzerButton = new System.Windows.Forms.Button();
            this.statisticTextBox = new System.Windows.Forms.TextBox();
            this.savePageButton = new System.Windows.Forms.Button();
            this.saveStatisticButton = new System.Windows.Forms.Button();
            this.statisticLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(46, 27);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(228, 13);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "Укажите URL-адрес страницы для анализа";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(291, 24);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(262, 20);
            this.urlTextBox.TabIndex = 1;
            // 
            // textAnalyzerButton
            // 
            this.textAnalyzerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textAnalyzerButton.Location = new System.Drawing.Point(568, 22);
            this.textAnalyzerButton.Name = "textAnalyzerButton";
            this.textAnalyzerButton.Size = new System.Drawing.Size(143, 23);
            this.textAnalyzerButton.TabIndex = 2;
            this.textAnalyzerButton.Text = "Проанализировать текст";
            this.textAnalyzerButton.UseVisualStyleBackColor = true;
            this.textAnalyzerButton.Click += new System.EventHandler(this.textAnalyzerButton_Click);
            // 
            // statisticTextBox
            // 
            this.statisticTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statisticTextBox.Location = new System.Drawing.Point(49, 148);
            this.statisticTextBox.Multiline = true;
            this.statisticTextBox.Name = "statisticTextBox";
            this.statisticTextBox.ReadOnly = true;
            this.statisticTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.statisticTextBox.Size = new System.Drawing.Size(816, 374);
            this.statisticTextBox.TabIndex = 3;
            // 
            // savePageButton
            // 
            this.savePageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePageButton.Location = new System.Drawing.Point(717, 22);
            this.savePageButton.Name = "savePageButton";
            this.savePageButton.Size = new System.Drawing.Size(138, 23);
            this.savePageButton.TabIndex = 4;
            this.savePageButton.Text = "Сохранить текст в файл";
            this.savePageButton.UseVisualStyleBackColor = true;
            this.savePageButton.Click += new System.EventHandler(this.savePageButton_Click);
            // 
            // saveStatisticButton
            // 
            this.saveStatisticButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStatisticButton.Location = new System.Drawing.Point(700, 533);
            this.saveStatisticButton.Name = "saveStatisticButton";
            this.saveStatisticButton.Size = new System.Drawing.Size(165, 23);
            this.saveStatisticButton.TabIndex = 5;
            this.saveStatisticButton.Text = "Сохранить статистику в файл";
            this.saveStatisticButton.UseVisualStyleBackColor = true;
            this.saveStatisticButton.Click += new System.EventHandler(this.saveStatisticButton_Click);
            // 
            // statisticLabel
            // 
            this.statisticLabel.AutoSize = true;
            this.statisticLabel.Location = new System.Drawing.Point(46, 111);
            this.statisticLabel.Name = "statisticLabel";
            this.statisticLabel.Size = new System.Drawing.Size(279, 13);
            this.statisticLabel.TabIndex = 6;
            this.statisticLabel.Text = "Статистика по количеству уникальных слов в тексте:";
            // 
            // TextAnalyzerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 587);
            this.Controls.Add(this.statisticLabel);
            this.Controls.Add(this.saveStatisticButton);
            this.Controls.Add(this.savePageButton);
            this.Controls.Add(this.statisticTextBox);
            this.Controls.Add(this.textAnalyzerButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Name = "TextAnalyzerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button textAnalyzerButton;
        private System.Windows.Forms.TextBox statisticTextBox;
        private System.Windows.Forms.Button savePageButton;
        private System.Windows.Forms.Button saveStatisticButton;
        private System.Windows.Forms.Label statisticLabel;
    }
}

