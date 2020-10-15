
namespace PowerShellCpuid.CmdLets.Results
{
    using iTin.Hardware.Specification.Cpuid;

    /// <summary>
    /// Class that defines the <see cref="SubLeaf"/> query consult.
    /// </summary>
    public class SubLeafResult
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
        /// Gets or sets a value that represents a sub-leaf.
        /// <para type="description">Name of the sub-leaf.</para>
        /// </summary>
        /// <value>
        /// One of the values of the <see cref="SubLeaf"/> enumeration.
        /// </value>
        public SubLeaf SubLeaf { get; set; }
    }
}
