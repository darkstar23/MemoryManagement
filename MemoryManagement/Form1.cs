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

        public MemoryBlock FREE_MEM_BLOCK_SEARCH(List<SystemMemoryBlock> MEM)
        {
            MemoryBlock FREE_MEM = new MemoryBlock(0, 0, 0, 0);
            int CNT2 = 0, CNT_BEGIN2 = 0;

            for(int i =0; i < MEM_SIZE; i++)
            {
                if(MEM[i].get_Assigned_ProcessID() == 0)
                {
                    CNT2 += 1;
                    if(CNT2 == 1)
                    {
                        CNT_BEGIN2 = i;
                    }
                    else if (CNT2 > 0)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if(CNT2 == 0)
            {
                FREE_MEM.set_MemoryStart(CNT_BEGIN2);
                FREE_MEM.setMemoryEnd(CNT_BEGIN2);
            }
            else if (CNT2 != 0)
            {
                FREE_MEM.set_MemoryStart(CNT_BEGIN2);
                FREE_MEM.setMemoryEnd((FREE_MEM.get_MemoryStart() + CNT2));
            }
            FREE_MEM.set_MemorySize(FREE_MEM.get_MemoryEnd() - CNT_BEGIN2);

            return FREE_MEM;
        }

        public void FREE_MEM_LIST_UPDATE()
        {
            FREE_MEM_BLOCK_LIST.Clear();

            for(int i = 0; i < MEM_SIZE; i++)
            {
                FREE_MEM_BLOCK_LIST.Add(FREE_MEM_BLOCK_SEARCH(SYS_MEM_BLOCK));
                if(FREE_MEM_BLOCK_LIST[i].get_MemoryEnd() == MEM_SIZE)
                {
                    break;
                }
            }
        }

        public MemoryBlock USED_MEM_BLOCK_SEARCH(List<SystemMemoryBlock> MEM)
        {
            MemoryBlock USED_MEM = new MemoryBlock(0, 0, 0, 0);
            int CNT = 0;
            int CNT_BEGIN = 0;
            int PID = 0;

            for(int i = 0; i < MEM_SIZE; i++)
            {
                if(MEM[i].get_Assigned_ProcessID() != 0)
                {
                    CNT += 1;
                    if(CNT == 1)
                    {
                        CNT_BEGIN = i;
                        PID = MEM[i - 1].get_Assigned_ProcessID();
                    }
                }
                else if(CNT > 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            if(CNT == 0)
            {
                USED_MEM.set_MemoryStart(CNT_BEGIN);
                USED_MEM.setMemoryEnd(CNT_BEGIN);
            }
            else if(CNT != 0)
            {
                USED_MEM.set_MemoryStart(CNT_BEGIN);
                USED_MEM.set_AssignedProcessID(PID);
                USED_MEM.setMemoryEnd( ( USED_MEM.get_MemoryStart() + (CNT - 1) ) );
            }
            USED_MEM.set_MemorySize( ( USED_MEM.get_MemoryEnd() - CNT_BEGIN ) );

            return USED_MEM;
        }

        public void USED_MEM_LIST_UPDATE()
        {
            USED_MEM_BLOCK_LIST.Clear();
            MemoryBlock MEM_BLOCK = new MemoryBlock();

            for(int i = 0; i < MEM_SIZE; i++)
            {
               MEM_BLOCK = (USED_MEM_BLOCK_SEARCH(SYS_MEM_BLOCK));
               if(MEM_BLOCK.get_MemorySize() != 0)
                {
                    USED_MEM_BLOCK_LIST.Add(MEM_BLOCK);
                }
            }
        }

        public void UPDATE_SUSPENDED_PROC_LIST()
        {
            SUSPENDED_PROC_LIST.Clear();
            for(int i = 0; i < ALL_PROC_LIST.Count; i++)
            {
                if(ALL_PROC_LIST[i].get_ProcessStatus() == ProcessStatus.WAITING)
                {
                    SUSPENDED_PROC_LIST.Add(ALL_PROC_LIST[i]);
                }
            }
        }

        public void assign_MEM_BLOCK(Process PROC, List<MemoryBlock> MEM)
        {
            for(int i = 0; i < MEM.Count; i++)
            {
                if(PROC.get_ProcessSize() <= MEM[i].get_MemorySize())
                {
                    for(int j = MEM[i].get_MemoryStart(); j < PROC.get_ProcessSize(); j++)
                    {
                        SYS_MEM_BLOCK[j].set_AssignedProcessID(PROC.get_PID());
                    }
                    PROC.set_ProcessStatus(ProcessStatus.RUNNING);
                  UPDATE_SUSPENDED_PROC_LIST();
                }
            }
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

        private void button_Simulate_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(textBox_CoalescingT.Text, @"^\d+$") && Regex.IsMatch(textBox_CompactionT.Text, @"^\d+$") && textBox_CoalescingT.Text != null && textBox_CompactionT.Text != null)
            {
                textBox_CoalescingT.Enabled = false;
                textBox_CompactionT.Enabled = false;

                for(int i = 0; i < ALL_PROC_LIST.Count; i++)
                {
                    if (ALL_PROC_LIST[i].get_ProcessStatus() == ProcessStatus.WAITING)
                    {
                        assign_MEM_BLOCK(ALL_PROC_LIST[i], FREE_MEM_BLOCK_LIST);

                        FREE_MEM_LIST_UPDATE();

                        USED_MEM_LIST_UPDATE();
                    }
                }
            }
        }
    }
}