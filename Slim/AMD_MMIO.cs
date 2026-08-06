using ZenStates.Core.Drivers;

namespace ZenStates.Core
{
    /// <summary>
    /// Slim-build stub for the original AMD_MMIO class (BCLK/strap access via IODriver).
    /// Inert: BCLK operations return null/false/default.
    /// </summary>
    public class AMD_MMIO
    {
        public enum ClkGen : int
        {
            ERROR = -1,
            EXTERNAL = 0,
            INTERNAL = 1,
        }

        private static readonly AMD_MMIO _instance = new AMD_MMIO(null);

        public static AMD_MMIO Instance => _instance;

        public AMD_MMIO(IODriver io) { }

        public double? GetBclk() => null;

        public ClkGen GetStrapStatus() => default;

        public bool SetBclk(double blck) => false;
    }
}
