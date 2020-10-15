
namespace PowerShellCpuid.CmdLets.Results
{
    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Cpuid;

    /// <summary>
    /// Class that defines the location of a <see cref="CPUID"/> property.
    /// </summary>
    public class PropertyDefinitionResult
    {
        /// <summary>
        /// Gets a value that contains the hexadecimal representation of the leaf to which this property belongs.
        /// <para type="description">Hexadecimal representation of the leaf to which this property belongs.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the hexadecimal representation of the leaf.
        /// </value>
        public string HexadecimalLeafId { get; set; }

        /// <summary>
        /// Gets or sets a value that contains the name of the leaf to which this property belongs.
        /// <para type="description">Name of the leaf to which this property belongs.</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="Leaf"/> enumeration.
        /// </value>
        public Leaf Leaf { get; set; }

        /// <summary>
        /// Gets or sets a value that contains the name of the sub-leaf to which this property belongs.
        /// <para type="description">Name of the sub-leaf to which this property belongs.</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="SubLeaf"/> enumeration.
        /// </value>
        public SubLeaf SubLeaf { get; set; }

        /// <summary>
        /// Gets or sets a value containing key that represents the property.
        /// <para type="description">Key that represents the property.</para>
        /// </summary>
        /// <value>
        /// An instance that implements the <see cref="IPropertyKey"/> interface that represents the key of the property.
        /// </value>
        public IPropertyKey PropertyKey { get; set; }
    }
}
