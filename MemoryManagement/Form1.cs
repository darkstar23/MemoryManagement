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

namespace MemoryManagement
{
    public partial class Form1 : Form
    {
       public List<SystemMemoryBlock> SYS_MEM_BLOCK = new List<SystemMemoryBlock>();
       public List<MemoryBlock> FREE_MEM_BLOCK_LIST = new List<MemoryBlock>();
       public List<MemoryBlock> USED_MEM_BLOCK_LIST = new List<MemoryBlock>();

       public List<Process> ALL_PROC_LIST = new List<Process>();
       public List<Process> ACTIVE_PROC_LIST = new List<Process>();
       public List<Process> SUSPENDED_PROC_LIST = new List<Process>();

       public enum ProcessStatus { RUNNING, WAITING, FINISHED };

       public Form1()
       {
           InitializeComponent();
       }

       private void Form1_Load(object sender, EventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }
    }
}