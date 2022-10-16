# ExtendedTopologyInformation Leaf

Contains the available properties for a leaf 0000000B - Extended Topology Information

## Available Properties

| Name | Description | Returns | Units |
| --- | --- | --- | --- |
| **BitsShiftRightx2APICID** | Number of bits to shift right on x2APIC ID to get a unique topology ID of the next level type. All logical processors with the same next level ID share current level. | UInt32 | None |
| **LevelType** | Gets a value representing the key to retrieve the property value. | String | None |
| **NumberOfLogicalProcessorsThisLevel** | Number of logical processors at this level type. The number reflects configuration as shipped by Intel. This value in this field is only intended for display/diagnostic purposes. The actual number of logical processors available to BIOS/OS/Applications may be different from this value, depending on software and platform hardware configurations. | UInt32 | None |
| **x2APICID** | x2APIC ID the current logical processor. | UInt32 | None |
