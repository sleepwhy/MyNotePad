using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyNotePad
{
    internal class ToolsClass
    {
        public static void WordCounter(RichTextBox mainRichTextBox)
        {
            int wordCount = mainRichTextBox.Text.Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            MessageBox.Show($"This notepad contains {wordCount} words.",
                            "Word Counter",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        public static void AutoSave(Timer timer)
        {
            SetTimerForm setTimerForm = new SetTimerForm(timer);

            setTimerForm.ShowDialog();
        }

        public static void secondTick(RichTextBox mainRichTextBox, ToolStripStatusLabel label)
        {
            label.Text = "               Auto Save:";
            if (Properties.Settings.Default.secondValue < Properties.Settings.Default.autoSaveTime)
            {
                Properties.Settings.Default.secondValue++;
            }
            else
            {
                Properties.Settings.Default.secondValue = 0;
                label.Text = "               Saved!";
                FileClass.SaveFile(mainRichTextBox);
            }
            
        }

        public static void textStatistics(RichTextBox mainRichTextBox)
        {
            int charCount = mainRichTextBox.Text.Length;
            int wordCount = mainRichTextBox.Text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            int lineCount = mainRichTextBox.Lines.Length;
            int spaceCount = mainRichTextBox.Text.Count(c => c == ' ');

            MessageBox.Show($"Characters: {charCount}\nWords: {wordCount}\nLines: {lineCount}\nSpaces: {spaceCount}",
                            "Text Statistics", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public static void setTheme(string theme, RichTextBox mainRichTextBox)
        {
            if (theme == null) return;

            switch(theme){

                case "dark":
                    Properties.Settings.Default.ForeColor = Color.White;
                    Properties.Settings.Default.BackgroundColor = Color.Black;
                    break;
                case "light":
                    Properties.Settings.Default.ForeColor = Color.Black;
                    Properties.Settings.Default.BackgroundColor = Color.White;
                    break;
                case "retro":
                    Properties.Settings.Default.ForeColor = Color.FromArgb(217, 210, 186);
                    Properties.Settings.Default.BackgroundColor = Color.FromArgb(59, 59, 59);
                break;
            }
            mainRichTextBox.ForeColor = Properties.Settings.Default.ForeColor;
            mainRichTextBox.BackColor = Properties.Settings.Default.BackgroundColor;

            Properties.Settings.Default.Theme = theme;
        }

        public static void checkTheme(ToolStripMenuItem[] items)
        {
            foreach (ToolStripMenuItem item in items)
            {
                if(item.Text.ToLower() == Properties.Settings.Default.Theme.ToLower()) item.Checked = true;
                else item.Checked = false;
            }
        }

    }
}
