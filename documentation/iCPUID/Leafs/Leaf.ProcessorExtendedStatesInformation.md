# ProcessorExtendedStatesInformation Leaf

Contains the available properties for a leaf 0000000D - Processor Extended States Information

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **AVXState** | AVX State. | Boolean | None |
| **IA32_XSS** | Used for IA32_XSS. | Boolean | None |
| **Lower32Bits_IA32_XSS** | Reports the supported bits of the lower 32 bits of the IA32_XSS MSR. | Boolean | None |
| **MaximumSizeAllSupportedFeatures** | Maximum size (bytes, from the beginning of the XSAVE/XRSTOR save area) of the XSAVE/XRSTOR save area required by all  supported features in the processor, i.e., all the valid bit fields in XCR0. | UInt32 | Bytes |
| **MaximumSizeEnabledFeaturesXCR0** | Maximum size (bytes, from the beginning of the XSAVE/XRSTOR save area) required by enabled features in XCR0. May be different than ECX if some features at the end of the XSAVE save area are not enabled. | UInt32 | Bytes |
| **OffsetThisExtenndedStateComponent** | The offset in bytes of this extended state component’s save area from the beginning of the XSAVE/XRSTOR area. This field reports 0 if the sub-leaf index, n, does not map to a valid bit in the XCR0 register. | UInt32 | Bytes |
| **PKRUState** | PKRU State. | Boolean | Bytes |
| **SizeAllStatesEnabled** | The size in bytes of the XSAVE area containing all states enabled by XCRO &#x7C; IA32_XSS. | UInt32 | Bytes |
| **SizeSaveAreaExtendedStateFeature** | The size in bytes (from the offset specified in EBX) of the save area for an extended state feature associated with a valid sub-leaf index, n. | UInt32 | Bytes |
| **SSEState** | SSE State. | Boolean | None |
| **ThisSubLeafSuppoertedInIA32_XSR** | Is set if the bit n (corresponding to the sub-leaf index) is supported in the IA32_XSS MSR; it is clear if bit n is instead supported in XCR0. | Boolean | None |
| **Upper32Bits_IA32_XSS** | Reports the supported bits of the upper 32 bits of the IA32_XSS MSR. | UInt32 | Bytes |
| **UPPER32BITS_XCR0** | Reports the supported bits of the upper 32 bits of XCR0. XCR0[n+32] can be set to 1 only if EDX[n] is 1. | Boolean | None |
| **x87State** | x87 State. | Boolean | None |
| **XGETBV** | Supports XGETBV with sub-leaf 1. | Boolean | None |
| **XSAVEAREAUSED** | Is set if, when the compacted format of an XSAVE area is used, this extended state component located on the next 64-byte boundary following the preceding state component (otherwise, it is located immediately following the preceding state component). | Boolean | None |
| **XSAVEC** | Supports XSAVEC and the compacted form of XRSTOR if is true. | Boolean | None |
| **XSAVEOPT** | XSAVEOPT is available. | Boolean | None |
| **XSAVES_XRSTORS_IA32_XSS** | Supports XSAVES/XRSTORS and IA32_XSS if is true. | Boolean | None |
