using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class MemoryBlock
    {
        private int m_MemorySize;
        private int m_MemoryStart;
        private int m_MemoryEnd;
        private int m_AssignedProcessID;

        public MemoryBlock()
        {
            // Just an Empty Constructor
        }

        public MemoryBlock(int Mem_Size, int Mem_Start, int Mem_End, int Assigned_PROCID)
        {
            m_MemorySize = Mem_Size;
            m_MemoryStart = Mem_Start;
            m_AssignedProcessID = Assigned_PROCID;
        }

        public int get_MemorySize()
        {
            return m_MemorySize;
        }

        public void set_MemorySize(int m_Mem_Size)
        {
            this.m_MemorySize = m_Mem_Size;
        }

        public int get_MemoryStart()
        {
            return m_MemoryStart;
        }

        public void set_MemoryStart(int m_Mem_Start)
        {
            this.m_MemoryStart = m_Mem_Start;
        }

        public int get_MemoryEnd()
        {
            return m_MemoryEnd;
        }

        public void setMemoryEnd(int m_Mem_End)
        {
            this.m_MemoryEnd = m_Mem_End;
        }

        public int get_AssignedProcessID()
        {
            return m_AssignedProcessID;
        }

        public void set_AssignedProcessID(int m_Assigned_PID)
        {
            this.m_AssignedProcessID = m_Assigned_PID;
        }

    }
}
