using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class Process
    {
        private int m_ProcessID;
        private int m_ProcessSize;
        private int m_ProcessDuration;
        private MainActivity.ProcessStatus m_ProcessStatus;

        public Process()
        {
            // another constructor
        }

        public Process(int PID, int PROC_SIZE, int PROC_DURATION, MainActivity.ProcessStatus PROC_STAT)
        {
            m_ProcessID = PID;
            m_ProcessSize = PROC_SIZE;
            m_ProcessDuration = PROC_DURATION;
            m_ProcessStatus = PROC_STAT;
        }

        public int get_PID()
        {
            return m_ProcessID;
        }

        public void set_PID(int m_PID)
        {
            this.m_ProcessID = m_PID;
        }
        public int get_ProcessSize()
        {
            return m_ProcessSize;
        }

        public void set_ProcessSize(int m_Proc_Size)
        {
            this.m_ProcessSize = m_Proc_Size;
        }

        public int get_ProcessDuration()
        {
            return m_ProcessDuration;
        }

        public void set_ProcessDuration(int m_Proc_Duration)
        {
            this.m_ProcessDuration = m_Proc_Duration;
        }

        public MainActivity.ProcessStatus get_ProcessStatus()
        {
            return m_ProcessStatus;
        }

        public void set_ProcessStatus(MainActivity.ProcessStatus m_Proc_Stat)
        {
            this.m_ProcessStatus = m_Proc_Stat;
        }

    }
}
