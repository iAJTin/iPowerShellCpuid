
namespace PowerShellCpuid.CmdLets
{
    using System.Management.Automation;

    using iTin.Core.Hardware.Common;

    using Results;

    /// <summary>
    /// <para type="synopsis">
    /// Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the property is expressed, description and leaf to which it belongs.
    /// </para>
    /// <para type="description">
    /// The value of the property <b>Property</b> must be obtained by calling the <b>Get-CpuidProperty</b>, for more information see the help
    /// for the <b>Get-CpuidProperty</b> and the sample examples below.
    /// </para>
    /// </summary>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'Manufacturer'
    ///     and then with the result obtained, the 'Get-CpuidProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
    ///     Finally we call 'Get-CpuidPropertyDetail' to obtain all the available information about the 'Manufacturer' property.
    /// 
    ///     PS> Get-CpuidPropertyDetail -Property (Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name Manufacturer)) | CPUID-Property-Detail -Property (CPUID-Property -Property (CPUID-Locate-Property -Name Manufacturer))
    ///
    ///     Name         : Manufacturer
    ///     Value        : GenuineIntel
    ///     Units        : None
    ///     Leaf         : BasicInformation
    ///     FriendlyName : Manufacturer
    ///     Desctiption  : CPU's manufacturer ID string
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'CacheSize' and belong to sub-leaf 'Two'.
    ///     After the 'Get-CpuidProperty' call tries to obtain the property information with the result obtained, remember that a property consists of its key and its value.
    ///     Finally we call 'Get-CpuidPropertyDetail' to obtain all the available information about the 'CacheSize' property.
    /// 
    ///     PS> Get-CpuidPropertyDetail -Property (Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name CacheSize -SubLeaf Two)) | CPUID-Property-Detail -Property (CPUID-Property -Property (CPUID-Locate-Property -Name CacheSize -SubLeaf Two))
    ///
    ///     Name         : CacheSize
    ///     Value        : 262144
    ///     Units        : Bytes
    ///     Leaf         : DeterministicCacheParameters
    ///     FriendlyName : Cache Size
    ///     Desctiption  : Cache Size in Bytes
    /// 
    ///   </code>
    /// </example>
    /// <example>
    ///   <code>
    ///     The output may be different (depending on your system)!!!
    /// 
    ///     To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'AVX2'
    ///     and then with the result obtained, the 'Get-CpuidProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
    ///     Finally we call 'Get-CpuidPropertyDetail' to obtain all the available information about the 'AVX2' property.
    /// 
    ///     PS> Get-CpuidPropertyDetail -Property (Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name AVX2)) | CPUID-Property-Detail -Property (CPUID-Property -Property (CPUID-Locate-Property -Name AVX2))
    ///
    ///     Name         : AVX2
    ///     Value        : True
    ///     Units        : None
    ///     Leaf         : ExtendedFeatures
    ///     FriendlyName : AVX2
    ///     Desctiption  : Advanced Vector Extensions 2
    /// 
    ///   </code>
    /// </example>
    [Cmdlet(VerbsCommon.Get, "CpuidPropertyDetail")]
    [OutputType(typeof(PropertyDetailResult))]
    [Alias("CPUID-Property-Detail")]
    public class GetCpuidPropertyDetailCmdlet : Cmdlet
    {
        #region public properties

        #region [public] (PropertyItem) Property: Gets or sets a value that contains the property item data
        /// <summary>
        /// Gets or sets a value that contains the property information.
        /// <para type="description">A <see cref="PropertyItem"/> instance.</para>
        /// </summary>
        /// <value>
        /// A <see cref="PropertyItem"/> reference that contains the property information.
        /// </value>
        [Parameter(Mandatory = true, ValueFromPipeline = true, HelpMessage = "Enter a PropertyItem instance, use CpuidProperty for get one")]
        public PropertyItem Property { get; set; }
        #endregion

        #endregion

        #region protected override methdos

        #region [protected] {override} (void) ProcessRecord: Process the command
        /// <summary>
        /// Process the command.
        /// </summary>
        protected override void ProcessRecord()
        {
            WriteObject(
                new PropertyDetailResult
                {
                    Name = Property.Key.PropertyId.ToString(),
                    Value = Property.Value,
                    Units = Property.Key.PropertyUnit.ToString(),
                    Leaf = Property.Key.StructureId.ToString(),
                    FriendlyName = Property.Key.GetPropertyName(),
                    Desctiption = Property.Key.GetPropertyDescription()
                });
        }
        #endregion

        #endregion
    }
}
