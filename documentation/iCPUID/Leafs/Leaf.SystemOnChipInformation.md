# SystemOnChipInformation Leaf

Contains the available properties for a leaf 00000017 - System On Chip Information

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **IsVendorScheme** | If true, SOC Vendor ID field is assigned via an industry standard enumeration scheme. Otherwise, is assigned by Intel. | Boolean | None |
| **MaxSOCID** | Maximum input value of supported sub-leaf.| UInt32 | None |
| **ProjectID** | A unique number an SOC vendor assigns to its SOC projects. | UInt32 | None |
| **SocVendorId** | SOC Vendor ID. | UInt32 | None |
| **SteppingID** | A unique number within an SOC project that an SOC vendor assigns. | UInt32 | None |

## Available Sections

| Name | Description |
| --- | --- |
| **Chip** | Contains the available properties for the *Chip* section. |

### Chip Section

#### Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **SOCVendorBrandString** | SOC Vendor Brand String (partial string). You must concatenate all SOCVendorBrandString property from all sub-leafs to get full name. | String | None |
