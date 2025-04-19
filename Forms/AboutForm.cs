using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotePad.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = "About Notepad"; 
            this.ClientSize = new System.Drawing.Size(300, 100); 
            this.StartPosition = FormStartPosition.CenterScreen; 


            Label label = new Label();
            label.Text = "This Notepad application was developed by sleepwhy\n" +
                         "and inspired by Microsoft Notepad.\n\n";
            label.AutoSize = true; 
            label.Location = new System.Drawing.Point(20, 20); 


            this.Controls.Add(label);


            Button closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Location = new System.Drawing.Point(110, 70); 
            closeButton.Click += (sender, e) => this.Close(); 
            this.Controls.Add(closeButton);
        }
    }
}
