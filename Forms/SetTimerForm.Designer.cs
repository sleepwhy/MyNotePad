namespace MyNotePad
{
    partial class SetTimerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTimerForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.trackBarSec = new System.Windows.Forms.TrackBar();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.trackBarMin = new System.Windows.Forms.TrackBar();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.labelSecValue = new System.Windows.Forms.Label();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(126, 183);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 36);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(362, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // trackBarSec
            // 
            this.trackBarSec.Location = new System.Drawing.Point(150, 81);
            this.trackBarSec.Maximum = 59;
            this.trackBarSec.Name = "trackBarSec";
            this.trackBarSec.Size = new System.Drawing.Size(305, 45);
            this.trackBarSec.TabIndex = 5;
            this.trackBarSec.TickFrequency = 5;
            this.trackBarSec.Scroll += new System.EventHandler(this.trackBarSec_Scroll);
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.Location = new System.Drawing.Point(29, 81);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(81, 24);
            this.labelSecond.TabIndex = 6;
            this.labelSecond.Text = "Second:";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinute.Location = new System.Drawing.Point(29, 132);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(72, 24);
            this.labelMinute.TabIndex = 7;
            this.labelMinute.Text = "Minute:";
            // 
            // trackBarMin
            // 
            this.trackBarMin.Location = new System.Drawing.Point(150, 132);
            this.trackBarMin.Maximum = 59;
            this.trackBarMin.Name = "trackBarMin";
            this.trackBarMin.Size = new System.Drawing.Size(305, 45);
            this.trackBarMin.TabIndex = 9;
            this.trackBarMin.TickFrequency = 5;
            this.trackBarMin.Scroll += new System.EventHandler(this.trackBarMin_Scroll);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoSave.Location = new System.Drawing.Point(196, 15);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(106, 26);
            this.labelAutoSave.TabIndex = 10;
            this.labelAutoSave.Text = "Auto Save";
            // 
            // labelSecValue
            // 
            this.labelSecValue.AutoSize = true;
            this.labelSecValue.Location = new System.Drawing.Point(457, 84);
            this.labelSecValue.Name = "labelSecValue";
            this.labelSecValue.Size = new System.Drawing.Size(13, 13);
            this.labelSecValue.TabIndex = 11;
            this.labelSecValue.Text = "0";
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(455, 135);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(13, 13);
            this.labelMinValue.TabIndex = 12;
            this.labelMinValue.Text = "0";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(244, 183);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 36);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // SetTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 256);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelMinValue);
            this.Controls.Add(this.labelSecValue);
            this.Controls.Add(this.labelAutoSave);
            this.Controls.Add(this.trackBarMin);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.trackBarSec);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetTimerForm";
            this.Text = "SetTimerForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TrackBar trackBarSec;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.TrackBar trackBarMin;
        private System.Windows.Forms.Label labelAutoSave;
        private System.Windows.Forms.Label labelSecValue;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Button btnStop;
    }
}