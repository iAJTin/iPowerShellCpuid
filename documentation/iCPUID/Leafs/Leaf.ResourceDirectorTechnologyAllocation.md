# ResourceDirectorTechnologyAllocation Leaf

Contains the available properties for a leaf 00000010 - Resource Director Technology Allocation

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **L2CacheAllocation** | L2 Cache Allocation. Supports L2 Cache Allocation Technology. | Boolean | None |
| **L3CacheAllocation** | L3 Cache Allocation. Supports L3 Cache Allocation Technology. | Boolean | None |

## Available Sections

| Name | Description |
| --- | --- |
| **ResId** | Contains the available properties for the *ResId* section. |

### Item Section

#### Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **BitGranularMap** | Bit-granular map of isolation/contention of allocation units. | UInt32 | None |
| **CodeDataPriorization** | Code and Data Prioritization Technology. | Boolean | None |
| **COS** | Updates of COS should be infrequent. | Boolean | None |
| **Highest_COS** | Highest COS number supported for this ResID. | UInt32 | None |
| **LengthBitMask** | Length of the capacity bit mask for the corresponding ResID using minus-one notation. | UInt32 | None |
