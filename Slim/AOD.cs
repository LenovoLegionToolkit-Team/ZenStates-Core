using ZenStates.Core.Drivers;

namespace ZenStates.Core
{
    /// <summary>
    /// Slim-build stub for the original AOD (AMD OverDrive interface, IODriver-based).
    /// Inert — only stored by Cpu, never used by the OC path.
    /// </summary>
    public class AOD
    {
        public AOD(IODriver io, Cpu cpuInstance) { }
    }
}
