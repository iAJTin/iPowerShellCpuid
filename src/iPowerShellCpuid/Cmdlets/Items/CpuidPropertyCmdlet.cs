
namespace PowerShellCpuid.CmdLets
{
    using System.Management.Automation;

    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Cpuid;

    using Helpers;
    using Results;

    /// <summary>
    /// <para type="synopsis">
    /// Returns a reference that contains the information associated with the given property such as the key that identifies the property and its value.
    /// </para>
    /// <para type="description">
    /// The value of the property <b>Property</b> must be obtained by calling the <b>Get-CpuidLocateProperty</b>, for more information see the help
    /// for the <b>Get-CpuidLocateProperty</b> and the sample examples below.
    /// </para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.
    /// 
    ///     PS> Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name Manufacturer) | CPUID-Property -Property (CPUID-Locate-Property -Name Manufacturer)
    ///     Get-CpuidProperty : Can not continue. CPUID instruction is not available in this system
    ///     ...
    ///     ...
    ///     ...
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'Manufacturer'
    ///     and then with the result obtained, the 'Get-CpuidProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
    /// 
    ///     PS> Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name Manufacturer) | CPUID-Property -Property (CPUID-Locate-Property -Name Manufacturer)
    ///
    ///     Key                                                                Value
    ///     ---                                                                -----
    ///     Structure = BasicInformation, Property = Manufacturer, Unit = None GenuineIntel
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'CacheSize' and belong to sub-leaf 'Two'.
    ///     After the 'Get-CpuidProperty' call tries to obtain the property information with the result obtained, remember that a property consists of its key and its value.
    /// 
    ///     PS> Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name CacheSize -SubLeaf Two) | CPUID-Property -Property (CPUID-Locate-Property -Name CacheSize -SubLeaf Two)
    ///
    ///     Key                                                                           Value
    ///     ---                                                                           -----
    ///     Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes 262144
    ///   </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CpuidProperty")]
    [OutputType(typeof(PropertyDefinitionResult), typeof(string))]
    [Alias("CPUID-Property")]
    public class GetCpuidPropertyCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (PropertyDefinitionResult) Property: Gets or sets a value that contains the name of the leaf to consult
        /// <summary>
        /// Gets or sets a value that contains the location property data.
        /// <para type="description">A <see cref="PropertyDefinitionResult"/> instance.</para>
        /// </summary>
        /// <value>
        /// A <see cref="PropertyDefinitionResult"/> reference that contains the location property data.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter an instance of PropertyDefinitionResult, use CpuidLocateProperty for get one")]
        public PropertyDefinitionResult Property { get; set; }
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
            if (!cpuid.IsAvailable)
            {
                WriteError(MessageHelper.CanNotContinueErrorRecord);
                return;
            }

            CpuidLeafDictionary leafs = cpuid.Leafs;
            CpuidSubLeafCollection leaf = leafs[Property.Leaf];
            LeafBase subLeaf = leaf[(int) Property.SubLeaf];
            QueryPropertyResult propertyResult = subLeaf.GetProperty(Property.PropertyKey);

            WriteObject(propertyResult.Value);
        }
        #endregion

        #endregion
    }
}
