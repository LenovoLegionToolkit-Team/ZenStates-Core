namespace ZenStates.Core
{
    /// <summary>
    /// Slim-build stub for the original SystemInfo (SMBIOS/registry system info).
    /// Inert — the field is only stored by Cpu and never dereferenced by the OC path.
    /// </summary>
    public class SystemInfo
    {
        public SystemInfo(Cpu.CPUInfo info, SMU smu, string agesaVersion) { }
    }
}
