using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class SystemMemoryBlock
    {
        private int m_Mem_Address;
        private int m_Assigned_PID;

        public SystemMemoryBlock()
        {
            // Just another empty constructor
        }

        public SystemMemoryBlock(int Mem_Address, int Assigned_PID)
        {
            m_Mem_Address = Mem_Address;
            m_Assigned_PID = Assigned_PID;
        }

        public int get_Mem_Address()
        {
            return m_Mem_Address;
        }

        public void set_Mem_Address(int m_Mem_Addr)
        {
            this.m_Mem_Address = m_Mem_Addr;
        }

        public int get_Assigned_ProcessID()
        {
            return m_Assigned_PID;
        }

        public void set_AssignedProcessID(int m_Ass_PID)
        {
            this.m_Assigned_PID = m_Ass_PID;
        }
    }
}
