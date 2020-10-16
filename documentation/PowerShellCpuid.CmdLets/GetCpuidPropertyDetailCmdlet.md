# GetCpuidPropertyDetailCmdlet class

Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the property is expressed, description and sheet to which it belongs.

The value of the property Property must be obtained by calling the Get-CpuidProperty, for more information see the help for the Get-CpuidProperty and the sample examples below.

```csharp
public class GetCpuidPropertyDetailCmdlet : Cmdlet
```

## Public Members

| name | description |
| --- | --- |
| [GetCpuidPropertyDetailCmdlet](GetCpuidPropertyDetailCmdlet/GetCpuidPropertyDetailCmdlet.md)() | The default constructor. |
| [Property](GetCpuidPropertyDetailCmdlet/Property.md) { get; set; } | Gets or sets a value that contains the property information. |

## Protected Members

| name | description |
| --- | --- |
| override [ProcessRecord](GetCpuidPropertyDetailCmdlet/ProcessRecord.md)() | Process the command. |

## Examples

```csharp
The output may be different (depending on your system)!!!

To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'Manufacturer'
and then with the result obtained, the 'Get-CpuidProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
Finally we call 'Get-CpuidPropertyDetail' to obtain all the available information about the 'Manufacturer' property.

PS> Get-CpuidPropertyDetail -Property (Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name Manufacturer))

Name         : Manufacturer
Value        : GenuineIntel
Units        : None
Leaf         : BasicInformation
FriendlyName : Manufacturer
Desctiption  : CPU's manufacturer ID string

```

```csharp
The output may be different (depending on your system)!!!

To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'CacheSize' and belong to sub-leaf 'Two'.
After the 'Get-CpuidProperty' call tries to obtain the property information with the result obtained, remember that a property consists of its key and its value.
Finally we call 'Get-CpuidPropertyDetail' to obtain all the available information about the 'CacheSize' property.

PS> Get-CpuidPropertyDetail -Property (Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name CacheSize -SubLeaf Two))

Name         : CacheSize
Value        : 262144
Units        : Bytes
Leaf         : DeterministicCacheParameters
FriendlyName : Cache Size
Desctiption  : Cache Size in Bytes

```

```csharp
The output may be different (depending on your system)!!!

To do this, first by calling 'Get-CpuidLocateProperty', we search among all the available properties of our system for those that call 'AVX2'
and then with the result obtained, the 'Get-CpuidProperty' call tries to obtain the property information, remember that a property it is made up of your key and its value.
Finally we call 'Get-CpuidPropertyDetail' to obtain all the available information about the 'AVX2' property.

PS> Get-CpuidPropertyDetail -Property (Get-CpuidProperty -Property (Get-CpuidLocateProperty -Name AVX2))

Name         : AVX2
Value        : True
Units        : None
Leaf         : ExtendedFeatures
FriendlyName : AVX2
Desctiption  : Advanced Vector Extensions 2

```

## See Also

* namespace [PowerShellCpuid.CmdLets](../iPowerShellCpuid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iPowerShellCpuid.dll -->