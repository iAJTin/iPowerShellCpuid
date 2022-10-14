
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;

using iTin.Hardware.Specification;
using iTin.Hardware.Specification.Cpuid;

using PowerShellCpuid.CmdLets.Results;
using PowerShellCpuid.Helpers;

namespace PowerShellCpuid.CmdLets
{
    /// <summary>
    /// <para type="synopsis">Returns all implemented sub-leafs for the given leaf.</para>
    /// <para type="description">Execute the CPUID instruction for the given leaf (eax register) and show all the sub-leafs it implements (ecx register).</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.
    /// 
    ///     PS> Get-CpuidSubLeafs -Leaf DeterministicCacheParameters
    ///     Get-CpuidSubLeafs : Can not continue. CPUID instruction is not available in this system
    ///     ...
    ///     ...
    ///     ...
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     Gets all implemented sub-leafs for 'Deterministic Cache Parameters' leaf
    /// 
    ///     PS> Get-CpuidSubLeafs -Leaf DeterministicCacheParameters | Cpuid-Sub-Leafs -Leaf DeterministicCacheParameters
    ///
    ///                           Leaf SubLeaf
    ///                           ---- -------
    ///   DeterministicCacheParameters Main
    ///   DeterministicCacheParameters One
    ///   DeterministicCacheParameters Two
    ///   DeterministicCacheParameters Three
    ///   </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CpuidSubLeafs")]
    [OutputType(typeof(SubLeafResult[]), typeof(string))]
    [Alias("CPUID-Sub-Leafs")]
    public class GetCpuidSubLeafsCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (Leaf) Leaf: Gets or sets a value that contains the name of the leaf to consult
        /// <summary>
        /// Gets or sets a value that contains the name of the leaf to consult.
        /// <para type="description">The name of the leaf to consult.</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="Leaf"/> enumeration.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter the leaf name, e.g. BasicInformation, ProcessorInfoAndFeatures")]
        public Leaf Leaf { get; set; }
        #endregion

        #endregion

        #region protected override methdos

        #region [protected] {override} (void) ProcessRecord: Process the command
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

            bool hasLeaf = cpuid.ImplementedLeafs.Contains(Leaf);
            if (!hasLeaf)
            {
                WriteObject($"The '{Leaf}' leaf is not implemented in this system");
                return;
            }

            WriteObject(string.Empty);
            var result = new Collection<SubLeafResult>();
            CpuidSubLeafCollection subLeafs = cpuid.Leafs[Leaf];
            foreach (LeafBase subLeaf in subLeafs)
            {
                result.Add(new SubLeafResult { SubLeaf = subLeaf.SubLeaf, Leaf = subLeaf.Leaf});
            }

            WriteObject((SubLeafResult[])result.ToArray().Clone(), true);
        }
        #endregion

        #endregion
    }
}
