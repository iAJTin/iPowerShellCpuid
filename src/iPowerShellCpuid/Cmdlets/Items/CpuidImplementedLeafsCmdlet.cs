
namespace PowerShellCpuid.CmdLets
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Management.Automation;

    using iTin.Hardware.Specification;

    using Helpers;
    using Results;

    /// <summary>
    /// <para type="synopsis">Returns a collection of elements where each element represents an implemented leaf.</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.
    /// 
    ///     PS> Get-CPUIDImplementedLeafs
    ///     Get-CPUIDImplementedLeafs : Can not continue. CPUID instruction is not available in this system
    ///     ...
    ///     ...
    ///     ...
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     PS> Get-CPUIDImplementedLeafs | CPUID-Implemented-Leafs
    /// 
    ///        LeafId HexadecimalLeafId                                       Leaf
    ///        ------ -----------------                                       ----
    ///             0 00000000                                    BasicInformation
    ///             1 00000001                            ProcessorInfoAndFeatures
    ///             2 00000002                                    CacheInformation
    ///             3 00000003                               ProcessorSerialNumber
    ///             4 00000004                        DeterministicCacheParameters
    ///             5 00000005                             MonitorAndMwaitFeatures
    ///             6 00000006                   ThermalAndPowerManagementFeatures
    ///             7 00000007                                    ExtendedFeatures
    ///             9 00000009                        DirectCacheAccessInformation
    ///            10 0000000A          ArchitecturalPerformanceMonitoringFeatures
    ///            11 0000000B                         ExtendedTopologyInformation
    ///            13 0000000D                  ProcessorExtendedStatesInformation
    ///            15 0000000F                ResourceDirectorTechnologyMonitoring
    ///            16 00000010                ResourceDirectorTechnologyAllocation
    ///            18 00000012                                                 Sgx
    ///            20 00000014                ProcessorTraceEnumerationInformation
    ///            21 00000015          TimeStampCounterAndNominalCoreCrystalClock
    ///   -2147483648 80000000                  HighestExtendedFunctionImplemented
    ///   -2147483647 80000001                    ExtendedProcessorInfoAndFeatures
    ///   -2147483646 80000002                                ProcessorBrandString
    ///   -2147483645 80000003                               ProcessorBrandString1
    ///   -2147483644 80000004                               ProcessorBrandString2
    ///   -2147483643 80000005                            L1CacheAndTlbIdentifiers
    ///   -2147483642 80000006                             ExtendedL2CacheFeatures
    ///   -2147483641 80000007                             AdvancedPowerManagement
    ///   </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "CpuidImplementedLeafs")]
    [OutputType(typeof(LeafResult[]), typeof(string))]
    [Alias("CPUID-Implemented-Leafs")]
    public class GetCpuidImplementedLeafsCmdlet : Cmdlet
    {
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            CPUID cpuid = CPUID.Instance;

            bool isAvailable = cpuid.IsAvailable;
            if (!isAvailable)
            {
                WriteError(MessageHelper.CanNotContinueErrorRecord);
                return;
            }

            var result = new Collection<LeafResult>();
            foreach(var leaf in cpuid.ImplementedLeafs)
            {
                result.Add(new LeafResult { Leaf = leaf, LeafId = (int)leaf, HexadecimalLeafId = $"{(int)leaf:X8}" });
            }

            WriteObject((LeafResult[])result.ToArray().Clone(), true);
        }
    }
}
