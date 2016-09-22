using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace MemoryManagement
{
    public partial class Form1 : Form
    {
        private int MEM_SIZE = 1000;
       public List<SystemMemoryBlock> SYS_MEM_BLOCK = new List<SystemMemoryBlock>();
       public List<MemoryBlock> FREE_MEM_BLOCK_LIST = new List<MemoryBlock>();
       public List<MemoryBlock> USED_MEM_BLOCK_LIST = new List<MemoryBlock>();

       public List<Process> ALL_PROC_LIST = new List<Process>();
       public List<Process> ACTIVE_PROC_LIST = new List<Process>();
       public List<Process> SUSPENDED_PROC_LIST = new List<Process>();
        int CNT_TO_NEXT_JOB = 0;

        public enum ProcessStatus { RUNNING, WAITING, FINISHED };

       public Form1()
       {
           InitializeComponent();
            textBox_CoalescingT.Enabled = false;
            textBox_CompactionT.Enabled = false;
            textBox_ProcSize.Enabled = false;
            textBox_ProcDuration.Enabled = false;
            button_NEXT_JOB.Enabled = false;
            

       }

       private void Form1_Load(object sender, EventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(textBox_NUM_JOBS != null && Regex.IsMatch(textBox_NUM_JOBS.Text, @"^\d+$"))
            {
                textBox_NUM_JOBS.Enabled = false;
                button_NEXT_JOB.Enabled = true;
                textBox_ProcDuration.Enabled = true;
                textBox_ProcSize.Enabled = true;
                button_Add.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please input a valid number.");
                textBox_NUM_JOBS.ResetText();
            }
        }

        private void button_NEXT_JOB_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox_ProcDuration.Text, @"^\d+$") && Regex.IsMatch(textBox_ProcSize.Text, @"^\d+$") && CNT_TO_NEXT_JOB < int.Parse(textBox_NUM_JOBS.Text) && int.Parse(textBox_ProcSize.Text) % 50 == 0)
            {
                ALL_PROC_LIST.Add(new MemoryManagement.Process((CNT_TO_NEXT_JOB + 1), int.Parse(textBox_ProcSize.Text), int.Parse(textBox_ProcDuration.Text), ProcessStatus.WAITING));
                SUSPENDED_PROC_LIST.Add(new MemoryManagement.Process((CNT_TO_NEXT_JOB + 1), int.Parse(textBox_ProcSize.Text), int.Parse(textBox_ProcDuration.Text), ProcessStatus.WAITING));
                label_PID_NUM.Text = (CNT_TO_NEXT_JOB + 1).ToString();
                richTextBox_Updater.AppendText("PID: "+ (CNT_TO_NEXT_JOB + 1).ToString() + " | Size:" + textBox_ProcSize.Text + " | Duration: " + textBox_ProcDuration.Text + "\n") ;
                textBox_ProcDuration.ResetText();
                textBox_ProcSize.ResetText();
                CNT_TO_NEXT_JOB += 1;

                
            }
            else if(CNT_TO_NEXT_JOB == int.Parse(textBox_NUM_JOBS.Text))
            {
                MessageBox.Show("Max Jobs are now at state waiting!");
                textBox_ProcDuration.Enabled = false;
                textBox_ProcSize.Enabled = false;
                button_NEXT_JOB.Enabled = false;
                textBox_CoalescingT.Enabled = true;
                textBox_CompactionT.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number, or a number divisible by 50. you should feel bad about yourself, not going to reset that field so you'll realize your mistake.");
            }
                
        }
    }
}