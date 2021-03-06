# GetCpuidSubLeafsCmdlet class

Returns all implemented sub-leafs for the given leaf.

Execute the CPUID instruction for the given leaf (eax register) and show all the sub-leafs it implements (ecx register).

```csharp
public class GetCpuidSubLeafsCmdlet : Cmdlet
```

## Public Members

| name | description |
| --- | --- |
| [GetCpuidSubLeafsCmdlet](GetCpuidSubLeafsCmdlet/GetCpuidSubLeafsCmdlet.md)() | The default constructor. |
| [Leaf](GetCpuidSubLeafsCmdlet/Leaf.md) { get; set; } | Gets or sets a value that contains the name of the leaf to consult. |

## Protected Members

| name | description |
| --- | --- |
| override [ProcessRecord](GetCpuidSubLeafsCmdlet/ProcessRecord.md)() | Process the command. |

## Examples

```csharp
If the CPUID instruction is not available, it always returns the message 'Can not continue. CPUID instruction is not available in this system'.

PS> Get-CpuidSubLeafs -Leaf DeterministicCacheParameters
Get-CpuidSubLeafs : Can not continue. CPUID instruction is not available in this system
...
...
...
```

```csharp
The output may be different (depending on your system)!!!

Gets all implemented sub-leafs for 'Deterministic Cache Parameters' leaf

PS> Get-CpuidSubLeafs -Leaf DeterministicCacheParameters | Cpuid-Sub-Leafs -Leaf DeterministicCacheParameters

                      Leaf SubLeaf
                      ---- -------
terministicCacheParameters Main
terministicCacheParameters One
terministicCacheParameters Two
terministicCacheParameters Three
```

## See Also

* namespace [PowerShellCpuid.CmdLets](../iPowerShellCpuid.md)

<!-- DO NOT EDIT: generated by xmldocmd for iPowerShellCpuid.dll -->
