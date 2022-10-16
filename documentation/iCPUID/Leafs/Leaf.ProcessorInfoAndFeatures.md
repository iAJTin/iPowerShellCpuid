# ProcessorInfoAndFeatures Leaf

Contains the available properties for a leaf 00000001 - Processor Info And Features Information

## Available Sections

| Name | Description |
| --- | --- |
| **Features** | Contains the available properties for the *Features* section. |
| **Processor** | Contains the available properties for the *Processor* section. |

### Features Section

#### Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **ACPI** | Thermal Monitor and Software Controlled Clock Facilities. The processor implements internal MSRs that allow processor temperature to be monitored and processor performance to be modulated in predefined duty cycles under software control. | Boolean | None |
| **AES** | AES instruction set. A value of true indicates that the processor supports the AES instruction extensions. | Boolean | None |
| **APIC** | APIC On-Chip. The processor contains an Advanced Programmable Interrupt Controller (APIC). | Boolean | None |
| **AVX** | Advanced Vector Extensions. A value of true indicates the processor supports the AVX instruction extensions. | Boolean | None |
| **CLFSH** | CLFLUSH Instruction. A value of true indicates the CLFLUSH Instruction is supported. | Boolean | None |
| **CMOV** | Conditional Move Instructions. A value of true indicates the conditional move instruction CMOV is supported. | Boolean | None |
| **CMPXCHG16B** | CMPXCHG16B Instruction Available. A value of true indicates that the feature is available. | Boolean | None |
| **CNXT_ID** | L1 Context ID. A value of true indicates the L1 data cache mode can be set to either adaptive mode or shared mode. A value of false indicates this feature is not supported. | Boolean | None |
| **CX8** | CMPXCHG8B Instruction. The compare-and-exchange 8 bytes (64 bits) instruction is supported (implicitly | Boolean | None |
| **DCA** | Direct cache access for DMA writes. A value of true indicates the processor supports the ability to prefetch data from a memory mapped device. | Boolean | None |
| **DE** | Debugging Extensions. A value of true indicates Support for I/O breakpoints. | Boolean | None |
| **DS** | Debug Store. The processor supports the ability to write debug information into a memory resident buffer. | Boolean | None |
| **DS_CPL** | CPL Qualified Debug Store. A value of true indicates the processor supports the the extensions to the Debug Store feature to allow for branch message storage qualified by CPL. | Boolean | None |
| **DTES64** | 64-bit DS Area. A value of true indicates the processor supports DS area using 64-bit layout. | Boolean | None |
| **EIST** | Enhanced Intel SpeedStep® technology. A value of true indicates the processor supports this technology. | Boolean | None |
| **F16C** | 16-bit floating-point conversion instructions. A value of true indicates that processor supports 16-bit floating-point conversion instructions. | Boolean | None |
| **FMA** | Fused multiply-add. A value of true indicates the processor supports FMA extensions using YMM state. | Boolean | None |
| **FPU** | Floating Point Unit On-Chip. A value of true indicates that processor contains an x87 FPU. | Boolean | None |
| **FXSR** | FXSAVE and FXRSTOR Instructions. The FXSAVE and FXRSTOR instructions are supported for fast save and restore of the floating point context. | Boolean | None |
| **HTT** | Max APIC IDs reserved field is Valid. A value of false indicates there is only a single logical processor in the package and software should assume only a single APIC ID is reserved. A value of true indicates the value in CPUID.1.EBX[23:16] (the Maximum number of addressable IDs for logical processors in this package) is valid for the package. | Boolean | None |
| **HYPERVISOR** | Hypervisor present. Guest operating systems can test this property to detect if they are running inside a virtual machine. | Boolean | None |
| **IA64** | IA64 processor emulating x86. A value of true indicates the processor supports IA64 processor emulating x86. | Boolean | None |
| **MCA** | Machine Check Architecture. A value of true indicates the Machine Check Architecture of reporting machine errors is supported. | Boolean | None |
| **MCE** | Machine Check Exception. Exception 18 is defined for Machine Checks, including CR4.MCE for controlling the feature. This feature does not define the model-specific implementations of machine-check error logging, reporting, and processor shutdowns. Machine Check exception handlers may have to depend on processor version to do model specific processing of the exception, or test for the presence of the Machine Check feature. | Boolean | None |
| **MMX** | Intel MMX Technology. A value of true indicates the processor supports the Intel MMX technology. | Boolean | None |
| **MONITOR** | MONITOR/MWAIT. A value of true indicates the processor supports this technology. | Boolean | None |
| **MOVBE** | MOVBE instruction. A value of true indicates that the processor supports MOVBE instruction. | Boolean | None |
| **MSR** | Model Specific Registers RDMSR and WRMSR Instructions. A value of true indicates the RDMSR and WRMSR instructions are supported. | Boolean | None |
| **MTRR** | Memory Type Range Registers. MTRRs are supported. The MTRRcap MSR contains feature bits that describe what memory types are supported, how many variable MTRRs are supported, and whether fixed MTRRs are supported. | Boolean | None |
| **OSXSAVE** | XSAVE enabled by OS. A value of true indicates that the XSAVE enabled by OS. | Boolean | None |
| **PAE** | Physical Address Extension. A value of true indicates physical addresses greater than 32 bits are supported: extended page table entry formats, an extra level in the page translation tables is defined, 2-MByte pages are supported instead of 4 Mbyte pages. | Boolean | None |
| **PAT** | Page Attribute Table. A value of true indicates the Page Attribute Table is supported. | Boolean | None |
| **PBE** | Pending Break Enable. A value of false indicates there is only a single logical processor in the package and software should assume only a single APIC ID is reserved. A value of true indicates the value in CPUID.1.EBX[23:16] (the Maximum number of addressable IDs for logical processors in this package) is valid for the package. | Boolean | None |
| **PCID** | Process-context identifiers. A value of true indicates that the processor supports PCIDs. | Boolean | None |
| **PCLMULQDQ** | PCLMULQDQ. A value of true indicates the processor supports PCLMULQDQ instruction. | Boolean | None |
| **PDCM** | Perfmon and Debug Capability. A value of true indicates that the processor supports the performance and debug feature indication MSR IA32_PERF_CAPABILITIES. | Boolean | None |
| **PGE** | Page Global Bit. The global bit is supported in paging-structure entries that map a page, indicating TLB entries that are common to different processes and need not be flushed. The CR4.PGE bit controls this feature. | Boolean | None |
| **POPCNT** | POPCNT instruction. A value of true indicates that the processor supports POPCNT instruction. | Boolean | None |
| **PSE** | Page Size Extension. A value of true indicates Large pages of size 4 MByte are supported. | Boolean | None |
| **PSE_36** | 36-Bit Page Size Extension. 4-MByte pages addressing physical memory beyond 4 GBytes are supported with 32-bit paging. | Boolean | None |
| **PSN** | Processor Serial Number. The processor supports the 96-bit processor identification number feature and the feature is enabled. | Boolean | None |
| **RDRAND** | On-chip random number generator feature. A value of true indicates that processor supports RDRAND instruction. | Boolean | None |
| **SDBG** | Silicon Debug interface. A value of true indicates the processor supports IA32_DEBUG_INTERFACE MSR for silicon debug. | Boolean | None |
| **SEP** | SYSENTER and SYSEXIT Instructions. The SYSENTER and SYSEXIT and associated MSRs are supported. | Boolean | None |
| **SMX** | Safer Mode Extensions. A value of true indicates the processor supports this technology. | Boolean | None |
| **SS** | Self Snoop. The processor supports the management of conflicting memory types by performing a snoop of its own cache structure for transactions issued to the bus. | Boolean | None |
| **SSE** | SSE Instructions. A value of true indicates the processor supports the SSE extensions. | Boolean | None |
| **SSE2** | SSE2 Instructions. A value of true indicates the processor supports the SSE2 extensions. | Boolean | None |
| **SSE3** | Streaming SIMD Extensions 3 (SSE3). A value of true indicates the processor supports this technology. | Boolean | None |
| **SSE41** | SSE4.1 instructions. A value of true indicates that the processor supports SSE4.1. | Boolean | None |
| **SSE42** | SSE4.2 instructions. A value of true indicates that the processor supports SSE4.2. | Boolean | None |
| **SSSE3** | Supplemental Streaming SIMD Extensions 3 (SSSE3). A value of true indicates the presence of the Supplemental Streaming SIMD Extensions 3 (SSSE3). | Boolean | None |
| **TM** | Thermal Monitor. The processor implements the thermal monitor automatic thermal control circuitry (TCC). | Boolean | None |
| **TM2** | Thermal Monitor 2. A value of true indicates the processor supports this technology. | Boolean | None |
| **TSC** | Time Stamp Counter. A value of true indicates the RDTSC instruction is supported. | Boolean | None |
| **TSC_Deadline** | TSC-Deadline instruction. A value of true indicates that the processor’s local APIC timer supports one-shot operation using a TSC deadline value. | Boolean | None |
| **VME** | Virtual 8086 Mode Enhancements. A value of true indicates Virtual 8086 mode enhancements. | Boolean | None |
| **VMX** | Virtual Machine Extensions. A value of true indicates the processor supports this technology. | Boolean | None |
| **x2APIC** | x2APIC feature. A value of true indicates that the processor supports x2APIC feature. | Boolean | None |
| **XSAVE** | AES instruction set. A value of true indicates that the processor supports the XSAVE/XRSTOR processor extended states feature, the XSETBV/XGETBV instructions, and XCR0. | Boolean | None |
| **xTPR** | CMPXCHG16B Instruction Available. A value of true indicates that the processor supports changing IA32_MISC_ENABLE. | Boolean | None |

### Processor Section

#### Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **BrandIndex** | Brand Index. This number provides an entry into a brand string table that contains brand strings for IA-32 processors. | Byte | None |
| **CLFLUSH_CacheLineSize** | CLFLUSH Cache Line Size. This number indicates the size of the cache line flushed by the CLFLUSH and CLFLUSHOPT instructions in 8-byte increments. This field was introduced in the Pentium 4 processor. | Byte | None |
| **CpuSignature** | Cpu Signature. | String | None |
| **LocalApicId** | Local APIC ID. The initial APIC-ID is used to identify the executing logical processor. This number is the 8-bit ID that is assigned to the local APIC on the processor during power up. This field was introduced in the Pentium 4 processor. It can also be identified via the **x2APICID**. | Byte | None |
