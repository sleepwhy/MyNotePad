using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    public static class FileClass
    {
        
        public static string NewNote(RichTextBox mainRichTextBox)
        {
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.path))
            {
                WantASave(mainRichTextBox);

            }
            else
            {
                try
                {
                    string fileContent = File.ReadAllText(Properties.Settings.Default.path);

                    string textBoxContent = mainRichTextBox.Text;

                    if (!string.Equals(fileContent, textBoxContent, StringComparison.Ordinal))
                    {
                        WantASave(mainRichTextBox);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return "";
        }


        public static void OpenNewWindow()
        {
            MainForm newForm = new MainForm();
            newForm.Show();
        }

        public static void OpenFile(RichTextBox mainRichTextBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Select File";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    string fileContent = File.ReadAllText(filePath);

                    if (!string.Equals(fileContent, mainRichTextBox.Text, StringComparison.Ordinal))
                    {
                        WantASave(mainRichTextBox);
                    }

                    mainRichTextBox.Text = fileContent;

                    Properties.Settings.Default.path = filePath;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message);
                }
            }
        }

        public static void SaveFile(RichTextBox mainRichTextBox)
        {

            if (string.IsNullOrEmpty(Properties.Settings.Default.path))
            {
               SaveAsFile(mainRichTextBox);
            }
            else
            {
                
                try
                {
                    File.WriteAllText(Properties.Settings.Default.path, mainRichTextBox.Text);

                    if(!Properties.Settings.Default.isAutoSaveOpen)
                    MessageBox.Show("The file was saved successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public static void SaveAsFile(RichTextBox mainRichTextBox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.path = saveFileDialog.FileName;
                SaveFile(mainRichTextBox);
            }


        }

        private static void WantASave(RichTextBox mainRichTextBox)
        {
            WantASaveForm wantASaveForm = new WantASaveForm();

            if(wantASaveForm.ShowDialog() == DialogResult.OK)
            {
                SaveAsFile(mainRichTextBox);
            }

        }

        public static void ExitApplication()
        {
            Application.Exit();
        }
        
    }
}

