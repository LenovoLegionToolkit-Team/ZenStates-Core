using System;

namespace ZenStates.Core.Drivers
{
    /// <summary>
    /// Slim-build stub for the original IODriver.
    /// Lenovo Legion Toolkit does not need port/MMIO access — SMU mailbox and MSR
    /// access go through the user-installed PawnIO driver instead — so this stub
    /// keeps the full Cpu API surface compiling without any driver loading code.
    /// </summary>
    public sealed class IODriver : IDisposable
    {
        public enum LibStatus
        {
            INITIALIZE_ERROR = 0,
            OK = 1,
            PARTIALLY_OK = 2
        }

        public IODriver() { }

        public void Dispose() { }

        public void DlPortWritePortUlong(ushort port, uint value) { }

        public uint DlPortReadPortUlong(ushort port) => 0;

        public byte[] ReadMemory(IntPtr baseAddress, int size) => null;
    }
}
