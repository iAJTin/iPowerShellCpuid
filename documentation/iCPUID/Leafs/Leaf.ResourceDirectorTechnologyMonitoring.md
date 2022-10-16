# ResourceDirectorTechnologyMonitoring Leaf

Contains the available properties for a leaf 0000000F - Resource Director Technology Monitoring

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **L3CacheIntelRDT** | L3 Cache Intel RDT. Supports L3 Cache Intel RDT Monitoring. | Boolean | None |
| **MaximumRangeAllTypes** | Maximum range (zero-based) of RMID within this physical processor of all types. | UInt32 | None |

## Available Sections

| Name | Description |
| --- | --- |
| **Item** | Contains the available properties for the *Item* section. |

### Item Section

#### Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **ConversionFactorThis** | Conversion factor from reported IA32_QM_CTR value to occupancy metric (bytes) | UInt32 | Bytes |
| **L3LBRAND** | Supports L3 Local Bandwidth monitoring. | Boolean | None |
| **L3OCC** | Supports L3 occupancy monitoring. | Boolean | None |
| **L3TBRAND** | Supports L3 Total Bandwidth monitoring. | Boolean | None |
| **MaximumRangeThis** | Maximum range (zero-based) of RMID of this resource type. | UInt32 | None |
