
namespace PowerShellCpuid.Helpers
{
    using System;
    using System.Management.Automation;

    using iTin.Hardware.Specification;

    /// <summary>
    /// Static class for handle the known error messages.
    /// </summary>
    internal static class MessageHelper
    {
        private const string CanNotContinue = "Can not continue. CPUID instruction is not available in this system";

        /// <summary>
        /// Build a <see cref="ErrorRecord"/> when <see cref="CPUID"/> instruction is not available in this system
        /// </summary>
        /// <returns>
        /// A <see cref="ErrorRecord"/> reference that contains error message when CPUID instruction is not available in this system.
        /// </returns>
        public static ErrorRecord CanNotContinueErrorRecord => new ErrorRecord(
            new InvalidOperationException(MessageHelper.CanNotContinue),
            "CpuidNotAvailable",
            ErrorCategory.InvalidOperation,
            false);
    }
}
