using System;

namespace ZenStates.Core.Drivers
{
    public class SmbusDriverBase : IDisposable
    {
        public void Dispose() { }
    }

    internal static class SmbusProvider
    {
        internal static SmbusDriverBase Instance => new SmbusDriverBase();
    }
}
