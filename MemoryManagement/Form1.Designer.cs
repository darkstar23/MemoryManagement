namespace MemoryManagement
{
    partial class Form1
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
            this.label_PID = new System.Windows.Forms.Label();
            this.label_ProcSize = new System.Windows.Forms.Label();
            this.label_ProcDuration = new System.Windows.Forms.Label();
            this.textBox_PID = new System.Windows.Forms.TextBox();
            this.textBox_ProcSize = new System.Windows.Forms.TextBox();
            this.textBox_ProcDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_PID
            // 
            this.label_PID.AutoSize = true;
            this.label_PID.Location = new System.Drawing.Point(12, 56);
            this.label_PID.Name = "label_PID";
            this.label_PID.Size = new System.Drawing.Size(28, 13);
            this.label_PID.TabIndex = 0;
            this.label_PID.Text = "PID:";
            this.label_PID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_ProcSize
            // 
            this.label_ProcSize.AutoSize = true;
            this.label_ProcSize.Location = new System.Drawing.Point(12, 92);
            this.label_ProcSize.Name = "label_ProcSize";
            this.label_ProcSize.Size = new System.Drawing.Size(71, 13);
            this.label_ProcSize.TabIndex = 1;
            this.label_ProcSize.Text = "Process Size:";
            // 
            // label_ProcDuration
            // 
            this.label_ProcDuration.AutoSize = true;
            this.label_ProcDuration.Location = new System.Drawing.Point(12, 138);
            this.label_ProcDuration.Name = "label_ProcDuration";
            this.label_ProcDuration.Size = new System.Drawing.Size(91, 13);
            this.label_ProcDuration.TabIndex = 2;
            this.label_ProcDuration.Text = "Process Duration:";
            // 
            // textBox_PID
            // 
            this.textBox_PID.Location = new System.Drawing.Point(111, 53);
            this.textBox_PID.Name = "textBox_PID";
            this.textBox_PID.Size = new System.Drawing.Size(81, 20);
            this.textBox_PID.TabIndex = 3;
            // 
            // textBox_ProcSize
            // 
            this.textBox_ProcSize.Location = new System.Drawing.Point(111, 89);
            this.textBox_ProcSize.Name = "textBox_ProcSize";
            this.textBox_ProcSize.Size = new System.Drawing.Size(81, 20);
            this.textBox_ProcSize.TabIndex = 4;
            // 
            // textBox_ProcDuration
            // 
            this.textBox_ProcDuration.Location = new System.Drawing.Point(111, 135);
            this.textBox_ProcDuration.Name = "textBox_ProcDuration";
            this.textBox_ProcDuration.Size = new System.Drawing.Size(81, 20);
            this.textBox_ProcDuration.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 426);
            this.Controls.Add(this.textBox_ProcDuration);
            this.Controls.Add(this.textBox_ProcSize);
            this.Controls.Add(this.textBox_PID);
            this.Controls.Add(this.label_ProcDuration);
            this.Controls.Add(this.label_ProcSize);
            this.Controls.Add(this.label_PID);
            this.Name = "Form1";
            this.Text = "Mem Mgmt simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PID;
        private System.Windows.Forms.Label label_ProcSize;
        private System.Windows.Forms.Label label_ProcDuration;
        private System.Windows.Forms.TextBox textBox_PID;
        private System.Windows.Forms.TextBox textBox_ProcSize;
        private System.Windows.Forms.TextBox textBox_ProcDuration;
    }
}

