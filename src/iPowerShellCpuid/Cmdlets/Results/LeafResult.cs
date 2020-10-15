
namespace PowerShellCpuid.CmdLets.Results
{
    using iTin.Hardware.Specification.Cpuid;

    /// <summary>
    /// Class that defines the <see cref="Leaf"/> query consult.
    /// </summary>
    public class LeafResult
    {
        /// <summary>
        /// Gets or sets a value that represents a leaf.
        /// <para type="description">Name of the leaf.</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="Leaf"/> enumeration.
        /// </value>
        public Leaf Leaf { get; set; }

        /// <summary>
        /// Gets a value that contains the numeric representation of the leaf
        /// <para type="description">Numeric representation of the leaf.</para>
        /// </summary>
        /// <value>
        /// A <see cref="int"/> that contains the numeric representation of the leaf.
        /// </value>
        public int LeafId { get; set; }

        /// <summary>
        /// Gets a value that contains the hexadecimal representation of the leaf
        /// <para type="description">Hexadecimal representation of the leaf.</para>
        /// </summary>
        /// <value>
        /// A <see cref="string"/> that contains the hexadecimal representation of the leaf.
        /// </value>
        public string HexadecimalLeafId { get; set; }
    }
}
