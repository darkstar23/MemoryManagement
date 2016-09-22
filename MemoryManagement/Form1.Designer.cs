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
            this.textBox_NUM_JOBS = new System.Windows.Forms.TextBox();
            this.textBox_ProcSize = new System.Windows.Forms.TextBox();
            this.textBox_ProcDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_PID_NUM = new System.Windows.Forms.Label();
            this.textBox_CompactionT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CoalescingT = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_NEXT_JOB = new System.Windows.Forms.Button();
            this.richTextBox_Updater = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_PID
            // 
            this.label_PID.AutoSize = true;
            this.label_PID.Location = new System.Drawing.Point(12, 66);
            this.label_PID.Name = "label_PID";
            this.label_PID.Size = new System.Drawing.Size(81, 13);
            this.label_PID.TabIndex = 0;
            this.label_PID.Text = "Number of jobs:";
            this.label_PID.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_ProcSize
            // 
            this.label_ProcSize.AutoSize = true;
            this.label_ProcSize.Location = new System.Drawing.Point(12, 92);
            this.label_ProcSize.Name = "label_ProcSize";
            this.label_ProcSize.Size = new System.Drawing.Size(94, 13);
            this.label_ProcSize.TabIndex = 1;
            this.label_ProcSize.Text = "Process Size (KB):";
            // 
            // label_ProcDuration
            // 
            this.label_ProcDuration.AutoSize = true;
            this.label_ProcDuration.Location = new System.Drawing.Point(12, 118);
            this.label_ProcDuration.Name = "label_ProcDuration";
            this.label_ProcDuration.Size = new System.Drawing.Size(115, 13);
            this.label_ProcDuration.TabIndex = 2;
            this.label_ProcDuration.Text = "Process Duration (TU):";
            // 
            // textBox_NUM_JOBS
            // 
            this.textBox_NUM_JOBS.Location = new System.Drawing.Point(133, 63);
            this.textBox_NUM_JOBS.Name = "textBox_NUM_JOBS";
            this.textBox_NUM_JOBS.Size = new System.Drawing.Size(81, 20);
            this.textBox_NUM_JOBS.TabIndex = 3;
            // 
            // textBox_ProcSize
            // 
            this.textBox_ProcSize.Location = new System.Drawing.Point(133, 89);
            this.textBox_ProcSize.Name = "textBox_ProcSize";
            this.textBox_ProcSize.Size = new System.Drawing.Size(81, 20);
            this.textBox_ProcSize.TabIndex = 4;
            // 
            // textBox_ProcDuration
            // 
            this.textBox_ProcDuration.Location = new System.Drawing.Point(133, 115);
            this.textBox_ProcDuration.Name = "textBox_ProcDuration";
            this.textBox_ProcDuration.Size = new System.Drawing.Size(81, 20);
            this.textBox_ProcDuration.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Compaction time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PID:";
            // 
            // label_PID_NUM
            // 
            this.label_PID_NUM.AutoSize = true;
            this.label_PID_NUM.Location = new System.Drawing.Point(159, 47);
            this.label_PID_NUM.Name = "label_PID_NUM";
            this.label_PID_NUM.Size = new System.Drawing.Size(25, 13);
            this.label_PID_NUM.TabIndex = 8;
            this.label_PID_NUM.Text = "PID";
            // 
            // textBox_CompactionT
            // 
            this.textBox_CompactionT.Location = new System.Drawing.Point(133, 141);
            this.textBox_CompactionT.Name = "textBox_CompactionT";
            this.textBox_CompactionT.Size = new System.Drawing.Size(81, 20);
            this.textBox_CompactionT.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Coalescing time:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_CoalescingT
            // 
            this.textBox_CoalescingT.Location = new System.Drawing.Point(133, 167);
            this.textBox_CoalescingT.Name = "textBox_CoalescingT";
            this.textBox_CoalescingT.Size = new System.Drawing.Size(81, 20);
            this.textBox_CoalescingT.TabIndex = 11;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(231, 61);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(127, 23);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "ADD JOBS";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_NEXT_JOB
            // 
            this.button_NEXT_JOB.Location = new System.Drawing.Point(231, 92);
            this.button_NEXT_JOB.Name = "button_NEXT_JOB";
            this.button_NEXT_JOB.Size = new System.Drawing.Size(127, 23);
            this.button_NEXT_JOB.TabIndex = 13;
            this.button_NEXT_JOB.Text = "NEXT JOB";
            this.button_NEXT_JOB.UseVisualStyleBackColor = true;
            this.button_NEXT_JOB.Click += new System.EventHandler(this.button_NEXT_JOB_Click);
            // 
            // richTextBox_Updater
            // 
            this.richTextBox_Updater.Location = new System.Drawing.Point(393, 47);
            this.richTextBox_Updater.Name = "richTextBox_Updater";
            this.richTextBox_Updater.Size = new System.Drawing.Size(262, 96);
            this.richTextBox_Updater.TabIndex = 14;
            this.richTextBox_Updater.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 266);
            this.Controls.Add(this.richTextBox_Updater);
            this.Controls.Add(this.button_NEXT_JOB);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_CoalescingT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_CompactionT);
            this.Controls.Add(this.label_PID_NUM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ProcDuration);
            this.Controls.Add(this.textBox_ProcSize);
            this.Controls.Add(this.textBox_NUM_JOBS);
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
        private System.Windows.Forms.TextBox textBox_NUM_JOBS;
        private System.Windows.Forms.TextBox textBox_ProcSize;
        private System.Windows.Forms.TextBox textBox_ProcDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_PID_NUM;
        private System.Windows.Forms.TextBox textBox_CompactionT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_CoalescingT;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_NEXT_JOB;
        private System.Windows.Forms.RichTextBox richTextBox_Updater;
    }
}

