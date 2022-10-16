# ProcessorTraceEnumerationInformation Leaf

Contains the available properties for a leaf 00000014 - Processor Trace Enumeration Information

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **CPSB** | If true, indicates support of Configurable PSB and Cycle-Accurate Mode. | Boolean | None |
| **IA32_RTIT_CTL** | If true, indicates that IA32_RTIT_CTL.CR3Filter can be set to 1, and that IA32_RTIT_CR3_MATCH MSR can be accessed. | Boolean | None |
| **IA32_RTIT_CTL_TRC** | If true, indicates support of IP Filtering, TraceStop filtering, and preservation of Intel PT MSRs across warm reset. | Boolean | None |
| **IPFILTER** | If true, indicates support of Configurable PSB and Cycle-Accurate Mode. | Boolean | None |
| **IPPAY** | If true, generated packets which contain IP payloads have LIP values, which include the CS base component.. | Boolean | None |
| **MaximumSubLeafs** | Maximum sub-leaf supported. | UInt32 | None |
| **MTC_TIMMING** | If true, indicates support of MTC timing packet and suppression of COFI-based packets. | Boolean | None |
| **PTWRITE** | If true, indicates support of PTWRITE. Writes can set IA32_RTIT_CTL[12] (PTWEn) and IA32_RTIT_CTL[5] (FUPonPTW), and PTWRITE | Boolean | None |
| **PWEVTR** | If true, indicates support of Power Event Trace. Writes can set IA32_RTIT_CTL[4] (PwrEvtEn), enabling Power Event Trace packet generation. | Boolean | None |
| **SNGLRNG** | If true, indicates support of Single-Range Output scheme. | Boolean | None |
| **TOPA** | If true, ToPA tables can hold any number of output entries, up to the maximum allowed by the Mas- kOrTableOffset field of IA32_RTIT_OUTPUT_MASK_PTRS. | Boolean | None |
| **TRCTNPT** | If true, indicates support of output to Trace Transport subsystem. | Boolean | None |

## Available Sections

| Name | Description |
| --- | --- |
| **Item** | Contains the available properties for the *Item* section. |

### Item Section

#### Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **BitmapCycle** | Bitmap of supported Cycle Threshold value encodings. | UInt32 | None |
| **BitmapMTC** | Bitmap of supported MTC period encodings. | UInt32 | None |
| **BitmapPSB** | Bitmap of supported Configurable PSB frequency encodings. | UInt32 | None |
| **NumberConfigurableAddress** | Number of configurable Address Ranges for filtering. | UInt32 | None |
