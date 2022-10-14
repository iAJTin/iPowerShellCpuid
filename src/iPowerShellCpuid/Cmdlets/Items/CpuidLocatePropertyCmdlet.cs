
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

using iTin.Core.Helpers;
using iTin.Core.Hardware.Common;

using iTin.Hardware.Specification;
using iTin.Hardware.Specification.Cpuid;

using PowerShellCpuid.CmdLets.Results;
using PowerShellCpuid.Helpers;

namespace PowerShellCpuid.CmdLets
{
    /// <summary>
    /// <para type="synopsis">
    /// Returns a value that contains the location or locations of the cpuid property by its name.
    /// </para>
    /// <para type="description"> 
    /// If you get multiple results you can filter the result indicating the specific leaf and sub-leaf. For more information, please see the examples below.
    /// </para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.
    /// 
    ///     PS> Get-CpuidLocateProperty -Name Manufacturer
    ///     Get-CpuidLocateProperty : Can not continue. CPUID instruction is not available in this system
    ///     ...
    ///     ...
    ///     ...
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'Manufacturer' property.
    ///     The result of the search tells us that it belongs to the 'BasicInformation' leaf and is located in the 'Main' sub-leaf,
    ///     additionally the 'Structure' property stores the key that identifies this property.
    /// 
    ///     Notice, as it only returns one element.
    /// 
    ///     PS> Get-CpuidLocateProperty -Name Manufacturer | CPUID-Locate-Property -Name Manufacturer
    ///
    ///                 Leaf SubLeaf HexadecimalLeafId PropertyKey
    ///                 ---- ------- ----------------- -----------
    ///     BasicInformation    Main 00000000          Structure = BasicInformation, Property = Manufacturer, Unit = None
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'CacheSize' property.
    ///     The result of the search tells us that it belongs to the 'DeterministicCacheParameters' and 'ExtendedL2CacheFeatures' leafs and is also found in several sub-leafs.
    /// 
    ///     Notice, as it now returns an array containing the matches
    /// 
    ///     PS> Get-CpuidLocateProperty -Name CacheSize | CPUID-Locate-Property -Name CacheSize
    ///
    ///                             Leaf SubLeaf HexadecimalLeafId PropertyKey
    ///                             ---- ------- ----------------- -----------
    ///     DeterministicCacheParameters    Main 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    ///     DeterministicCacheParameters     One 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    ///     DeterministicCacheParameters     Two 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    ///     DeterministicCacheParameters   Three 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    ///          ExtendedL2CacheFeatures    Main 80000006          Structure = ExtendedL2CacheFeatures, Property = CacheSize, Unit = KB
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the property 'CacheSize' but only that of the sub-leaf 'Two'.
    ///
    ///     Notice, as it only returns one element.
    /// 
    ///     PS> Get-CpuidLocateProperty -Name CacheSize -SubLeaf Two | CPUID-Locate-Property -Name CacheSize -SubLeaf Two
    ///
    ///                             Leaf SubLeaf HexadecimalLeafId PropertyKey
    ///                             ---- ------- ----------------- -----------
    ///     DeterministicCacheParameters     Two 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the property 'CacheSize' but only that of the sub-leaf 'Main'.
    /// 
    ///     Notice, as it now returns an array containing the matches
    /// 
    ///     PS> Get-CpuidLocateProperty -Name CacheSize -SubLeaf Main | CPUID-Locate-Property -Name CacheSize -SubLeaf Main
    ///
    ///                             Leaf SubLeaf HexadecimalLeafId PropertyKey
    ///                             ---- ------- ----------------- -----------
    ///     DeterministicCacheParameters    Main 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
    ///          ExtendedL2CacheFeatures    Main 80000006          Structure = ExtendedL2CacheFeatures, Property = CacheSize, Unit = KB
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    ///
    ///     The following example shows how to get the location of the 'CacheSize' property but only the one of the leaf 'ExtendedL2CacheFeatures' and sub-leaf 'Two'.
    /// 
    ///     Notice, as it only returns one element.
    /// 
    ///     PS> Get-CpuidLocateProperty -Name CacheSize -Leaf ExtendedL2CacheFeatures -SubLeaf Main | CPUID-Locate-Property -Name CacheSize -Leaf ExtendedL2CacheFeatures -SubLeaf Main
    ///
    ///                             Leaf SubLeaf HexadecimalLeafId PropertyKey
    ///                             ---- ------- ----------------- -----------
    ///          ExtendedL2CacheFeatures    Main 80000006          Structure = ExtendedL2CacheFeatures, Property = CacheSize, Unit = KB
    /// 
    ///   </code>
    ///</example>
    [Cmdlet(VerbsCommon.Get, "CpuidLocateProperty")]
    [OutputType(typeof(string), typeof(PropertyDefinitionResult), typeof(PropertyDefinitionResult[]))]
    [Alias("CPUID-Locate-Property")]
    public class GetCpuidLocatePropertyCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (string) Name: Gets or sets a value that contains the name of the property to locate
        /// <summary>
        /// Gets or sets a value that contains the name of the property to locate.
        /// <para type="description">The property name to locate.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the name of the property to locate.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter the property name to locate, e.g. Manufacturer, AVX2, CacheSize, DigitalTemperatureSensor")]
        public string Name { get; set; }
        #endregion

        #region [public] (Leaf?) Leaf: Gets or sets a value that contains the name of the leaf to which this property belongs
        /// <summary>
        /// Gets or sets a value that contains the name of the leaf to which this property belongs. This value is optional.
        /// <para type="description">Optional leaf name</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="Leaf"/> enumeration.
        /// </value>
        [Parameter(Mandatory = false, ValueFromPipeline = true, HelpMessage = "Enter the leaf name, e.g. BasicInformation, ProcessorInfoAndFeatures")]
        public Leaf? Leaf { get; set; }
        #endregion

        #region [public] (SubLeaf?) SubLeaf: Gets or sets a value that contains the name of the sub-leaf to which this property belongs
        /// <summary>
        /// Gets or sets a value that contains the name of the sub-leaf to which this property belongs. This value is optional.
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

            var result = new List<PropertyDefinitionResult>();
            var leafs = cpuid.Leafs;
            foreach (var (leaf, subLeafs) in leafs)
            {
                foreach (var subLeaf in subLeafs)
                {
                    foreach (IPropertyKey propertyKey in subLeaf.ImplementedProperties)
                    {
                        if (!propertyKey.PropertyId.ToString().Equals(Name, StringComparison.OrdinalIgnoreCase))
                        {
                            continue;
                        }

                        result.Add(
                            new PropertyDefinitionResult
                            {
                                Leaf = leaf,
                                SubLeaf = subLeaf.SubLeaf,
                                HexadecimalLeafId = $"{(int)leaf:X8}",
                                PropertyKey = propertyKey
                            });
                    }
                }
            }

            IEnumerable<PropertyDefinitionResult> leafFiltered = 
                Leaf.HasValue 
                    ? result.Where(property => property.Leaf == Leaf).ToList() 
                    : (result as IEnumerable<PropertyDefinitionResult>).ToList();

            IEnumerable<PropertyDefinitionResult> subLeafFilter;
            if (SubLeaf.HasValue)
            {
                subLeafFilter =
                    leafFiltered.Any()
                        ? leafFiltered.Where(property => property.SubLeaf == SubLeaf).ToList()
                        : result.Where(property => property.SubLeaf == SubLeaf).ToList();
            }
            else
            {
                subLeafFilter = (leafFiltered as IEnumerable<PropertyDefinitionResult>).ToList();
            }

            if (subLeafFilter.Count() == 1)
            {
                WriteObject(subLeafFilter.FirstOrDefault());
            }
            else
            {
                WriteObject((PropertyDefinitionResult[])subLeafFilter.ToArray().Clone(), true);
            }
        }
        #endregion

        #endregion
    }
}
