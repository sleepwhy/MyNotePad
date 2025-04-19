using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad
{
    internal class EditClass
    {
        public static void setEnabled(RichTextBox mainRichTextBox, ToolStripMenuItem cut, ToolStripMenuItem copy, 
            ToolStripMenuItem delete, ToolStripMenuItem paste, ToolStripMenuItem select)
        {

            bool isTextSelected = mainRichTextBox.SelectedText.Length > 0;

            cut.Enabled = isTextSelected;
            copy.Enabled = isTextSelected;
            delete.Enabled = isTextSelected;

            paste.Enabled = Clipboard.GetText().Length > 0;

            select.Enabled = mainRichTextBox.Text.Length != 0;

        }

        public static void makeUndo(RichTextBox mainRichTextBox)
        {
            if (mainRichTextBox.CanUndo)
            {
                mainRichTextBox.Undo();
            }
        }

        public static void makeCut(RichTextBox mainRichTextBox)
        {
            if(mainRichTextBox.SelectedText.Length > 0) mainRichTextBox.Cut();
        }

        public static void makeCopy(RichTextBox mainRichTextBox)
        {
            if (mainRichTextBox.SelectedText.Length > 0) mainRichTextBox.Copy();
        }

        public static void makePaste(RichTextBox mainRichTextBox)
        {
            mainRichTextBox.Paste();
        }

        public static void makeDelete(RichTextBox mainRichTextBox)
        {
            if (mainRichTextBox.SelectedText.Length > 0) mainRichTextBox.SelectedText = "";
        }

        public static void makeSelectAll(RichTextBox mainRichTextBox)
        {
            if (mainRichTextBox.Text.Length > 0) mainRichTextBox.SelectAll();
        }

        public static void openFindForm(RichTextBox mainRichTextBox)
        {
            FindForm findForm = new FindForm(mainRichTextBox);

            findForm.Show();
        }

        public static void addTime(RichTextBox mainRichTextBox)
        {
            DateTime dateTime = DateTime.Now;
            mainRichTextBox.AppendText(dateTime.ToString());  
        }
    }
}
