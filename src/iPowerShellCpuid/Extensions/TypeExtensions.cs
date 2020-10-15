
namespace PowerShellCpuid.Helpers
{
    using System;
    using System.Linq;
    using System.Reflection;

    using iTin.Core.Hardware.Common;

    /// <summary>
    /// Static class for handle <see cref="Type"/> type.
    /// </summary>
    internal static class TypeExtensions
    {
        /// <summary>
        /// Returns by reflection the property value for a given leaf type.
        /// </summary>
        /// <param name="leafType">Target leaf type</param>
        /// <param name="propertyName">Property name to recover</param>
        /// <returns>
        /// An instance that implements a <see cref="IPropertyKey"/> interface that represents the key of property.
        /// </returns>
        public static IPropertyKey GetPropertyKey(this Type leafType, string propertyName)
        {
            PropertyInfo pi =
                leafType
                    .GetProperties()
                    .FirstOrDefault(property => property.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase));
            
            return (IPropertyKey)pi?.GetValue(leafType);
        }
    }
}
