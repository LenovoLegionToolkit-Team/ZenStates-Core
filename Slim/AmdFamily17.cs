using OpenHardwareMonitor.Hardware;

namespace ZenStates.Core
{
    /// <summary>
    /// Slim-build stub for the original AmdFamily17 PawnIO module (MSR/SMN access).
    /// Kept as an inert stub so the full Cpu API surface compiles without loading
    /// the AMDFamily17.bin module. All reads return false/0 — the affected paths
    /// (SVI2 telemetry, patch level, MSR reads) are non-critical in Cpu init.
    /// </summary>
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
