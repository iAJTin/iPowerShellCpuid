# GetCpuidLocatePropertyCmdlet class

Returns a value that contains the location or locations of the cpuid property by its name.

If you get multiple results you can filter the result indicating the specific leaf and sub-leaf. For more information, please see the examples below.

```csharp
public class GetCpuidLocatePropertyCmdlet : Cmdlet
```

## Public Members

| name | description |
| --- | --- |
| [GetCpuidLocatePropertyCmdlet](GetCpuidLocatePropertyCmdlet/GetCpuidLocatePropertyCmdlet.md)() | The default constructor. |
| [Leaf](GetCpuidLocatePropertyCmdlet/Leaf.md) { get; set; } | Gets or sets a value that contains the name of the leaf to which this property belongs. This value is optional. |
| [Name](GetCpuidLocatePropertyCmdlet/Name.md) { get; set; } | Gets or sets a value that contains the name of the property to locate. |
| [SubLeaf](GetCpuidLocatePropertyCmdlet/SubLeaf.md) { get; set; } | Gets or sets a value that contains the name of the sub-leaf to which this property belongs. This value is optional. |

## Protected Members

| name | description |
| --- | --- |
| override [ProcessRecord](GetCpuidLocatePropertyCmdlet/ProcessRecord.md)() | Process the command. |

## Examples

```csharp
If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.

PS> Get-CpuidLocateProperty -Name Manufacturer
Get-CpuidLocateProperty : Can not continue. CPUID instruction is not available in this system
...
...
...
```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'Manufacturer' property.
The result of the search tells us that it belongs to the 'BasicInformation' leaf and is located in the 'Main' sub-leaf,
additionally the 'Structure' property stores the key that identifies this property.

Notice, as it only returns one element.

PS> Get-CpuidLocateProperty -Name Manufacturer | CPUID-Locate-Property -Name Manufacturer

            Leaf SubLeaf HexadecimalLeafId PropertyKey
            ---- ------- ----------------- -----------
BasicInformation    Main 00000000          Structure = BasicInformation, Property = Manufacturer, Unit = None

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'CacheSize' property.
The result of the search tells us that it belongs to the 'DeterministicCacheParameters' and 'ExtendedL2CacheFeatures' leafs and is also found in several sub-leafs.

Notice, as it now returns an array containing the matches

PS> Get-CpuidLocateProperty -Name CacheSize | CPUID-Locate-Property -Name CacheSize

                        Leaf SubLeaf HexadecimalLeafId PropertyKey
                        ---- ------- ----------------- -----------
DeterministicCacheParameters    Main 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
DeterministicCacheParameters     One 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
DeterministicCacheParameters     Two 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
DeterministicCacheParameters   Three 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
     ExtendedL2CacheFeatures    Main 80000006          Structure = ExtendedL2CacheFeatures, Property = CacheSize, Unit = KB

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the property 'CacheSize' but only that of the sub-leaf 'Two'.

Notice, as it only returns one element.

PS> Get-CpuidLocateProperty -Name CacheSize -SubLeaf Two | CPUID-Locate-Property -Name CacheSize -SubLeaf Two

                        Leaf SubLeaf HexadecimalLeafId PropertyKey
                        ---- ------- ----------------- -----------
DeterministicCacheParameters     Two 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the property 'CacheSize' but only that of the sub-leaf 'Main'.

Notice, as it now returns an array containing the matches

PS> Get-CpuidLocateProperty -Name CacheSize -SubLeaf Main | CPUID-Locate-Property -Name CacheSize -SubLeaf Main

                        Leaf SubLeaf HexadecimalLeafId PropertyKey
                        ---- ------- ----------------- -----------
DeterministicCacheParameters    Main 00000004          Structure = DeterministicCacheParameters, Property = CacheSize, Unit = Bytes
     ExtendedL2CacheFeatures    Main 80000006          Structure = ExtendedL2CacheFeatures, Property = CacheSize, Unit = KB

```

```csharp
The output may be different (depending on your system)!!!

The following example shows how to get the location of the 'CacheSize' property but only the one of the leaf 'ExtendedL2CacheFeatures' and sub-leaf 'Two'.

Notice, as it only returns one element.

PS> Get-CpuidLocateProperty -Name CacheSize -Leaf ExtendedL2CacheFeatures -SubLeaf Main | CPUID-Locate-Property -Name CacheSize -Leaf ExtendedL2CacheFeatures -SubLeaf Main

                        Leaf SubLeaf HexadecimalLeafId PropertyKey
                        ---- ------- ----------------- -----------
     ExtendedL2CacheFeatures    Main 80000006          Structure = ExtendedL2CacheFeatures, Property = CacheSize, Unit = KB

```

## See Also

* namespace [PowerShellCpuid.CmdLets](../iPowerShellCpuid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iPowerShellCpuid.dll -->
