
namespace PowerShellCpuid.Helpers
{
    using System;
    using System.Linq;

    using iTin.Core.Hardware.Common;

    using iTin.Hardware.Specification;
    using iTin.Hardware.Specification.Cpuid;

    /// <summary>
    /// Static class for handle <see cref="CPUID"/> properties.
    /// </summary>
    public static class CreatorHelper
    {
        private const string LeafPropertyNamespace = "iTin.Hardware.Specification.Cpuid.LeafProperty";

        /// <summary>
        /// Returns the property key for a given leaf and property name.
        /// </summary>
        /// <param name="leafName">Target leaf name</param>
        /// <param name="propertyName">Property name to recover</param>
        /// <returns>
        /// An instance that implements a <see cref="IPropertyKey"/> interface that represents the key of property.
        /// </returns>
        public static IPropertyKey CreatePropertyKeyFromArguments(string leafName, string propertyName)
        {
            var assembly = typeof(LeafProperty).Assembly;
            var leafPropertyType = assembly.GetType(LeafPropertyNamespace);

            return 
                leafPropertyType
                    .GetNestedTypes()
                    .FirstOrDefault(leaf => leaf.Name.Equals(leafName, StringComparison.OrdinalIgnoreCase))
                    .GetPropertyKey(propertyName);
        }
    }
}
