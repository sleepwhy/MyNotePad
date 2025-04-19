using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyNotePad.Forms;

namespace MyNotePad
{
    public partial class MainForm : Form
    {
        public string filePath;
        private ToolStripMenuItem[] themes;

        private CodeTyperCS codeTyperCS;
        private CodeTyperCPP codeTyperCPP;
        private CodeTyperPython codeTyperPython;

        public MainForm()
        {
            InitializeComponent();
            themes = new ToolStripMenuItem[] {lightToolStripMenuItem, darkToolStripMenuItem, retroToolStripMenuItem};

            codeTyperCS = new CodeTyperCS(MainRichTextBox);
            codeTyperCPP = new CodeTyperCPP(mainRichTextBox);
            codeTyperPython = new CodeTyperPython(mainRichTextBox);
        }



        /// File Section ///

        private void newNoteToolStripMenuItem_Click(object sender, EventArgs e) => FileClass.NewNote(mainRichTextBox);
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e) => FileClass.OpenNewWindow();
        private void openToolStripMenuItem_Click(object sender, EventArgs e) => FileClass.OpenFile(mainRichTextBox);
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => FileClass.SaveFile(mainRichTextBox);
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) => FileClass.SaveAsFile(mainRichTextBox);
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {

                printDoc.PrintPage += (s, ev) =>
                {
                    ev.Graphics.DrawString(mainRichTextBox.Text, new Font("Arial", 12), Brushes.Black, ev.MarginBounds);
                };
                printDoc.Print();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => FileClass.ExitApplication();



        /// Edit Section ///

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClass.setEnabled(mainRichTextBox, cutToolStripMenuItem, copyToolStripMenuItem, deleteToolStripMenuItem,
                pasteToolStripMenuItem, selectAllToolStripMenuItem);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.makeUndo(mainRichTextBox);
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.makeCut(mainRichTextBox);
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.makeCopy(mainRichTextBox);
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.makePaste(mainRichTextBox);
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.makeDelete(mainRichTextBox);
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.makeSelectAll(mainRichTextBox);
        private void findToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.openFindForm(mainRichTextBox);
        private void addTimeDateToolStripMenuItem_Click(object sender, EventArgs e) => EditClass.addTime(mainRichTextBox);



        /// Format Section ///
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.WordWrap = !mainRichTextBox.WordWrap;
            wordWrapToolStripMenuItem.Checked = mainRichTextBox.WordWrap;
        }
        public void ChangeFont()
        {
            FontDialog dialog = new FontDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mainRichTextBox.SelectionFont = dialog.Font;
                if (mainRichTextBox.SelectedText.Length == 0)
                {
                    mainRichTextBox.Font = dialog.Font;
                    toolStripStatusFont.Text = "          Font: " + dialog.Font.Name;
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e) => ZoomClass.ZoomIn(mainRichTextBox);
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e) => ZoomClass.ZoomOut(mainRichTextBox);

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrp.Visible = !statusStrp.Visible;
            statusBarToolStripMenuItem.Checked = statusStrp.Visible;
        }

        private void wordCounterToolStripMenuItem_Click(object sender, EventArgs e) => ToolsClass.WordCounter(mainRichTextBox);
        private void autoSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsClass.AutoSave(secondValueTimer);

            toolStripPgBarAutoSave.Maximum = Properties.Settings.Default.autoSaveTime;
            toolStripPgBarAutoSave.Value = 0;
        }

        

        private void secondValue_Tick(object sender, EventArgs e)
        {
            ToolsClass.secondTick(mainRichTextBox, toolStrpAutoSaveText);
            toolStripPgBarAutoSave.Value = Properties.Settings.Default.secondValue;
        }

        private void textStatisticsToolStripMenuItem_Click(object sender, EventArgs e) => ToolsClass.textStatistics(mainRichTextBox);


        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsClass.setTheme("light", mainRichTextBox);
            ToolsClass.checkTheme(themes);
            
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsClass.setTheme("dark", mainRichTextBox);
            ToolsClass.checkTheme(themes);
        }

        private void retroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsClass.setTheme("retro", mainRichTextBox);
            ToolsClass.checkTheme(themes);
        }

        private void deselectAll()
        {
            mainRichTextBox.SelectionStart = 0;
            mainRichTextBox.SelectionLength = 0;
        }

        private void setPropCodeTyp(string propCodeTyp)
        {
            if(Properties.Settings.Default.CodeTyper == propCodeTyp)
            {
                Properties.Settings.Default.CodeTyper = "";
                mainRichTextBox.SelectAll();
                mainRichTextBox.SelectionColor = Properties.Settings.Default.ForeColor;
                deselectAll();
                toolStripStatusLabelCodeTyper.Text = "           Code Typer: Off";
            }
            else
            {
                Properties.Settings.Default.CodeTyper = propCodeTyp;
                toolStripStatusLabelCodeTyper.Text = "           Code Typer: "+ propCodeTyp;
            }

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPropCodeTyp("CS");
            if(Properties.Settings.Default.CodeTyper == "CS")
            {
                codeTyperCS.ApplySyntaxHighlighting(MainRichTextBox.Text);
            }
                
            
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setPropCodeTyp("CPP");   
            if (Properties.Settings.Default.CodeTyper == "CPP")
            {
                codeTyperCPP.ApplySyntaxHighlighting(MainRichTextBox.Text);
            }
        }

        private void pythonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPropCodeTyp("Python"); 
            if (Properties.Settings.Default.CodeTyper == "Python")
            {
                codeTyperPython.ApplySyntaxHighlighting(MainRichTextBox.Text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }




        /// Shortcuts
        // Getter mainRichTextBox
        public RichTextBox MainRichTextBox
        {
            get { return mainRichTextBox; }
        }


        public int ProgressBar
        {
            set { toolStripPgBarAutoSave.Maximum = value; }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = StatusStrp.findLineAndRow(mainRichTextBox);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Shortcuts.AllShortcuts(sender, e, this);

            toolStripStatusLabel.Text = StatusStrp.findLineAndRow(mainRichTextBox);

            /// Other Shortcuts

            if (e.KeyCode == Keys.P && e.Control)
            {
                printToolStripMenuItem_Click(sender, e);
            }
        }


    }
}
