using System;

namespace ZenStates.Core.Drivers
{
    /// <summary>
    /// Slim-build stub for the original SMBus driver stack (SPD reading via IODriver).
    /// Inert — Cpu only stores the instance and disposes it.
    /// </summary>
    public class SmbusDriverBase : IDisposable
    {
        public void Dispose() { }
    }

    /// <summary>
    /// Slim-build stub for the original SmbusProvider singleton.
    /// </summary>
    internal static class SmbusProvider
    {
        internal static SmbusDriverBase Instance => new SmbusDriverBase();
    }
}
