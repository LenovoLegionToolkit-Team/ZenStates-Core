using OpenHardwareMonitor.Hardware;

namespace ZenStates.Core
{
    public sealed class AmdFamily17 : System.IDisposable
    {
        public AmdFamily17() { }

        public bool ReadMsr(uint index, out uint eax, out uint edx)
        {
            eax = 0;
            edx = 0;
            return false;
        }

        public bool ReadMsrTx(uint index, out uint eax, out uint edx, GroupAffinity affinity)
        {
            eax = 0;
            edx = 0;
            return false;
        }

        public bool WriteMsrTx(uint msr, uint eax, uint edx, GroupAffinity affinity) => false;

        public bool ReadSmnNoLock(uint addr, out uint data)
        {
            data = 0;
            return false;
        }

        public void Close() { }

        public void Dispose() { }
    }
}
