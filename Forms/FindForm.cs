using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public partial class FindForm : Form
    {
        RichTextBox mainRichTextBox;
        KeyValuePair<int, int> value = new KeyValuePair<int, int>(0, 0);

        public FindForm(RichTextBox mainRichTextBox)
        {
            InitializeComponent();
            this.mainRichTextBox = mainRichTextBox;
        }

        private string lastPattern = "";
        private MatchCollection matches;
        private int currentMatchIndex = -1;

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFind.Text))
            {
                MessageBox.Show("TextBox cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!(radioBtnDown.Checked || radioBtnUp.Checked))
            {
                MessageBox.Show("Direction cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string pattern = textBoxFind.Text;
                matches = Regex.Matches(mainRichTextBox.Text, pattern);

                if (pattern != lastPattern)
                {
                    lastPattern = pattern;
                    currentMatchIndex = radioBtnDown.Checked ? -1 : matches.Count;
                }

                int matchCount = matches.Count;
                if (matchCount == 0)
                {
                    MessageBox.Show("No matches found.");
                    labelFindCount.Visible = false;
                    return;
                }


                currentMatchIndex = radioBtnDown.Checked ? currentMatchIndex + 1 : currentMatchIndex - 1;

                if (currentMatchIndex >= matches.Count && radioBtnDown.Checked)
                {
                    if (checkBoxReturnEnd.Checked)
                    {
                        currentMatchIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("No other matches found in the text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        currentMatchIndex = matches.Count - 1;  
                    }
                }


                if (currentMatchIndex < 0 && radioBtnUp.Checked)
                {
                    if (checkBoxReturnEnd.Checked)
                    {
                        currentMatchIndex = matches.Count - 1;
                    }
                    else
                    {
                        MessageBox.Show("No other matches found in the text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        currentMatchIndex = 0;
                    }
                }

                Match match = matches[currentMatchIndex];

                resetValue();

                mainRichTextBox.SelectionStart = match.Index;
                mainRichTextBox.SelectionLength = match.Length;
                mainRichTextBox.SelectionColor = Color.Blue;
                mainRichTextBox.SelectionBackColor = Color.Yellow;
                mainRichTextBox.ScrollToCaret();
                mainRichTextBox.Focus();

                value = new KeyValuePair<int, int>(match.Index, match.Length);

                labelFindCount.Visible = true;
                labelFindCount.Text = $"Index: {currentMatchIndex + 1} / {matchCount}";
            }
            this.BringToFront();
        }

        private void resetValue()
        {
            mainRichTextBox.SelectionStart = value.Key;
            mainRichTextBox.SelectionLength = value.Value;
            mainRichTextBox.SelectionColor = mainRichTextBox.ForeColor;
            mainRichTextBox.SelectionBackColor = mainRichTextBox.BackColor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainRichTextBox.SelectionColor = Properties.Settings.Default.ForeColor;
            mainRichTextBox.SelectionBackColor = Properties.Settings.Default.BackgroundColor;
        }
    }
}
