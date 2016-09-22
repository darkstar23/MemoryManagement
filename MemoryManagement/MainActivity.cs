using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MemoryManagement
{
    public class MainActivity
    {
        private List<SystemMemoryBlock> SYS_MEM_BLOCK = new List<SystemMemoryBlock>();
        private List<MemoryBlock> FREE_MEM_BLOCK_LIST = new List<MemoryBlock>();
        private List<MemoryBlock> USED_MEM_BLOCK_LIST = new List<MemoryBlock>();

        private List<Process> ALL_PROC_LIST = new List<Process>();
        private List<Process> ACTIVE_PROC_LIST = new List<Process>();
        private List<Process> SUSPENDED_PROC_LIST = new List<Process>();

        public enum ProcessStatus { RUNNING, WAITING, FINISHED };
    }
}
