using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using NHunspell;

namespace MyTestTask.CheckingText
{
    /// <summary>
    /// Форма для проверки текста
    /// </summary>
    public partial class FormCheckingText : Form
    {
        private readonly Hunspell _spellChecker;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormCheckingText()
        {
            InitializeComponent();
            try
            {
                var affFilePath = ConfigurationManager.AppSettings["affFilePath"];
                var dictFilePath = ConfigurationManager.AppSettings["dictFilePath"];
                _spellChecker = new Hunspell(affFilePath, dictFilePath);
            }
            catch (Exception ex)
            {
                Enabled = false;
                MessageBox.Show(ex.Message);
            }         
        }

        /// <summary>
        /// Событие при изменении текста в поле ввода
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">e</param>
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as RichTextBox;
            string[] words = textBox.Text.Split(' ');
            int oldIndex = 0;
            textBox.HideSelection = true;
            foreach (string word in words)
            {
                int index = textBox.Text.IndexOf(word, oldIndex);
                textBox.Select(index, word.Length);
                if (!_spellChecker.Spell(word))
                {
                    textBox.SelectionColor = Color.Red;
                }
                else
                {
                    textBox.SelectionColor = Color.Black;
                }
                oldIndex = oldIndex + word.Length + 1;
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
