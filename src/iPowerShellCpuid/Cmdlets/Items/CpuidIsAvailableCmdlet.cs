
using System.Management.Automation;

using iTin.Hardware.Specification;

namespace PowerShellCpuid.CmdLets
{
    /// <summary>
    /// <para type="synopsis">Returns a value that indicates whether this system supports the CPUID instruction.</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     PS> Get-CpuidIsAvailable | CPUID-Is-Available
    ///     True   
    ///   </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "CpuidIsAvailable")]
    [OutputType(typeof(bool))]
    [Alias("CPUID-Is-Available")]
    public class GetCpuidIsAvailableCmdlet : Cmdlet
    {
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            WriteObject(CPUID.Instance.IsAvailable);
        }
    }
}
