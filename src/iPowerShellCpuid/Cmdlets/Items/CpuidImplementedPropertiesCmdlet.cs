
namespace PowerShellCpuid.CmdLets
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Management.Automation;

    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Cpuid;

    using Helpers;
    using Results;

    /// <summary>
    /// <para type="synopsis">Returns a collection of elements where each element represents an implemented property for given leaf, optionally you can specify the subleaf.</para>
    /// <para type="description">The elements are suitable to be used in the 'Get-CpuidProperty' operation as an input parameter of the '-Property' parameter.</para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.
    /// 
    ///     PS> Get-CpuidImplementedProperties -Leaf ProcessorInfoAndFeatures | CPUID-Implemented-Properties -Leaf ProcessorInfoAndFeatures
    ///     Get-CpuidImplementedProperties : Can not continue. CPUID instruction is not available in this system
    ///     ...
    ///     ...
    ///     ...
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the all implemented properties for the 'BasicInformation' CPUID leaf.
    ///     The search result returns a collection of objects with the property information.
    ///     The data type of the elements of the collection is suitable to be used as an input value in the '-Property' parameter
    ///     of the Get-CpuidProperty operation.
    /// 
    ///     PS> Get-CpuidImplementedProperties -Leaf BasicInformation | CPUID-Implemented-Properties -Leaf BasicInformation
    /// 
    ///     HexadecimalLeafId             Leaf SubLeaf PropertyKey
    ///     -----------------             ---- ------- -----------
    ///     00000000          BasicInformation Main Structure = BasicInformation, Property = HighestBasicFunction, Unit = None
    ///     00000000          BasicInformation Main Structure = BasicInformation, Property = Manufacturer, Unit = None
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the all implemented properties for the 'DeterministicCacheParameters' CPUID leaf and 'One' sub-leaf.
    ///     The search result returns a collection of objects with the property information.
    ///     The data type of the elements of the collection is suitable to be used as an input value in the '-Property' parameter
    ///     of the Get-CpuidProperty operation.
    /// 
    ///     PS> Get-CpuidImplementedProperties -Leaf DeterministicCacheParameters -SubLeaf One | CPUID-Implemented-Properties -Leaf DeterministicCacheParameters -SubLeaf One
    /// 
    ///     HexadecimalLeafId                         Leaf SubLeaf PropertyKey
    ///     -----------------                         ---- ------- -----------
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = CacheLevel, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = CacheType, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = WriteBack, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = UseDirectMappedCache, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = IsFullyAssociativeCache, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = IsCacheInclusiveOfLowerLevels, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = IsSelfInitializingCacheLevel, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = MaximumLogicalProcessorCores, Unit = None
    ///     00000004          DeterministicCacheParameters     One Structure = DeterministicCacheParameters, Property = MaximumPhysicalProcessorCores, Unit = None
    ///   </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "CpuidImplementedProperties")]
    [OutputType(typeof(PropertyDefinitionResult[]), typeof(string))]
    [Alias("CPUID-Implemented-Properties")]
    public class CpuidImplementedPropertiesCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (Leaf) Leaf: Gets or sets a value that contains the name of the leaf
        /// <summary>
        /// Gets or sets a value that contains the name of the leaf.
        /// <para type="description">Leaf name</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="Leaf"/> enumeration.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter the leaf name, e.g. BasicInformation, ProcessorInfoAndFeatures")]
        public Leaf Leaf { get; set; }
        #endregion

        #region [public] (SubLeaf?) SubLeaf: Gets or sets a value that contains the name of the sub-leaf
        /// <summary>
        /// Gets or sets a value that contains the name of the sub-leaf. This value is optional.
        /// <para type="description">Optional subleaf name</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="SubLeaf"/> enumeration.
        /// </value>
        [Parameter(Mandatory = false, ValueFromPipeline = true, HelpMessage = "Enter the sub-leaf name, e.g. Main, One, Two, Three")]
        public SubLeaf? SubLeaf { get; set; }
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

            CpuidLeafDictionary leafs = cpuid.Leafs;
            CpuidSubLeafCollection subLeafs = leafs[Leaf];

            var result = new List<PropertyDefinitionResult>();
            if (SubLeaf.HasValue)
            {
                LeafBase subLeaf = subLeafs[(int)SubLeaf];
                ReadOnlyCollection<IPropertyKey> properties = subLeaf.ImplementedProperties;
                foreach (var property in properties)
                {
                    result.Add(
                        new PropertyDefinitionResult
                        {
                            Leaf = Leaf,
                            SubLeaf = subLeaf.SubLeaf,
                            HexadecimalLeafId = $"{(int)Leaf:X8}",
                            PropertyKey = property
                        });
                }
            }
            else
            {
                foreach (var subLeaf in subLeafs)
                {
                    ReadOnlyCollection<IPropertyKey> properties = subLeaf.ImplementedProperties;
                    foreach (var property in properties)
                    {
                        result.Add(
                            new PropertyDefinitionResult
                            {
                                Leaf = Leaf,
                                SubLeaf = subLeaf.SubLeaf,
                                HexadecimalLeafId = $"{(int)Leaf:X8}",
                                PropertyKey = property
                            });
                    }
                }
            }
            
            WriteObject((PropertyDefinitionResult[])result.ToArray().Clone(), true);
        }
        #endregion

        #endregion
    }
}
