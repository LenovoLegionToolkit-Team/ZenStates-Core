using System;

namespace ZenStates.Core.Drivers
{
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
