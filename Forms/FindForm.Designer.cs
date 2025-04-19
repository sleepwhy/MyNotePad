namespace MyNotePad
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.fndLabel = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnDown = new System.Windows.Forms.RadioButton();
            this.radioBtnUp = new System.Windows.Forms.RadioButton();
            this.checkBoxReturnEnd = new System.Windows.Forms.CheckBox();
            this.labelFindCount = new System.Windows.Forms.Label();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fndLabel
            // 
            this.fndLabel.AutoSize = true;
            this.fndLabel.Location = new System.Drawing.Point(46, 96);
            this.fndLabel.Name = "fndLabel";
            this.fndLabel.Size = new System.Drawing.Size(30, 13);
            this.fndLabel.TabIndex = 0;
            this.fndLabel.Text = "Find:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(93, 92);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(192, 20);
            this.textBoxFind.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(308, 91);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find Next";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.radioBtnDown);
            this.mainGroupBox.Controls.Add(this.radioBtnUp);
            this.mainGroupBox.Location = new System.Drawing.Point(103, 129);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(182, 54);
            this.mainGroupBox.TabIndex = 4;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Direction";
            // 
            // radioBtnDown
            // 
            this.radioBtnDown.AutoSize = true;
            this.radioBtnDown.Location = new System.Drawing.Point(99, 19);
            this.radioBtnDown.Name = "radioBtnDown";
            this.radioBtnDown.Size = new System.Drawing.Size(53, 17);
            this.radioBtnDown.TabIndex = 1;
            this.radioBtnDown.TabStop = true;
            this.radioBtnDown.Text = "Down";
            this.radioBtnDown.UseVisualStyleBackColor = true;
            // 
            // radioBtnUp
            // 
            this.radioBtnUp.AutoSize = true;
            this.radioBtnUp.Location = new System.Drawing.Point(31, 19);
            this.radioBtnUp.Name = "radioBtnUp";
            this.radioBtnUp.Size = new System.Drawing.Size(39, 17);
            this.radioBtnUp.TabIndex = 0;
            this.radioBtnUp.TabStop = true;
            this.radioBtnUp.Text = "Up";
            this.radioBtnUp.UseVisualStyleBackColor = true;
            // 
            // checkBoxReturnEnd
            // 
            this.checkBoxReturnEnd.AutoSize = true;
            this.checkBoxReturnEnd.Location = new System.Drawing.Point(12, 189);
            this.checkBoxReturnEnd.Name = "checkBoxReturnEnd";
            this.checkBoxReturnEnd.Size = new System.Drawing.Size(128, 17);
            this.checkBoxReturnEnd.TabIndex = 5;
            this.checkBoxReturnEnd.Text = "Auto Return from End";
            this.checkBoxReturnEnd.UseVisualStyleBackColor = true;
            // 
            // labelFindCount
            // 
            this.labelFindCount.AutoSize = true;
            this.labelFindCount.Location = new System.Drawing.Point(90, 70);
            this.labelFindCount.Name = "labelFindCount";
            this.labelFindCount.Size = new System.Drawing.Size(36, 13);
            this.labelFindCount.TabIndex = 6;
            this.labelFindCount.Text = "Index:";
            this.labelFindCount.Visible = false;
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoSave.Location = new System.Drawing.Point(172, 20);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(96, 26);
            this.labelAutoSave.TabIndex = 11;
            this.labelAutoSave.Text = "Find Text";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 217);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.labelFindCount);
            this.Controls.Add(this.checkBoxReturnEnd);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.fndLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fndLabel;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.RadioButton radioBtnDown;
        private System.Windows.Forms.RadioButton radioBtnUp;
        private System.Windows.Forms.CheckBox checkBoxReturnEnd;
        private System.Windows.Forms.Label labelFindCount;
        private System.Windows.Forms.Label labelAutoSave;
    }
}