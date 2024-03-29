<p align="center">
  <img src="https://github.com/iAJTin/iPowerShellCpuid/blob/main/powershellgallery/iPowerShellCpuid.png" height="32">
</p>
<p align="center">
  <a href="https://github.com/iAJTin/iPowerShellCpuid">
    <img src="https://img.shields.io/badge/iTin-iPowerShellCpuid-green.svg?style=flat"/>
  </a>
</p>

***

# What is iPowerShellCpuid?

iPowerShellCpuid contains a collection of **PowerShell Cmdlets** that allow us to obtain the [CPUID] information.

Works on Windows, Linux and Mac.

# Install via PowerShellGallery

- From PowerShellGallery

    <table>
      <tr>
        <td>
          <a href="https://github.com/iAJTin/iPowerShellCpuid">
            <img src="https://img.shields.io/badge/-iPowerShellCpuid-green.svg?style=flat"/>
          </a>
        </td>
        <td>
          <a href="https://www.powershellgallery.com/packages/iPowerShellCpuid/">
            <img alt="PowerShellGallery Version" 
                 src="https://img.shields.io/powershellgallery/v/iPowerShellCpuid.svg?style=flat-square&label=iPowerShellCpuid" /> 
          </a>
        </td>  
      </tr>
    </table>

- From package manager console

    | User | Command |
    |:-----|:--------|
    | Administrator user |```Install-Module -Name iPowerShellCpuid -Force``` |
    | Current user |```Install-Module -Name iPowerShellCpuid -scope CurrentUser -Force``` |

# Install Locally

### Windows

| Step | Description |
|:----:|:------------|
| 1 | Create the ```iPowerShellCpuid``` folder in ```%programfiles%\WindowsPowerShell\Modules``` |
| 2 | Copy the contents of the output folder ```Release``` or ```Debug``` into the folder created in the previous step. ```%programfiles%\WindowsPowerShell\Modules\iPowerShellCpuid```. |
| 3 | Run Windows PowerShell |
| 4 | For import **iPowerShellCpuid** module, please enter the following command: ```PS> Import-Module iPowerShellCpuid``` |
| 5 | Now try to get the information of available commands, please enter the following command: ```PS> Get-Help Cpuid``` |
| 6 | Now to check that everything is correct, let's check if the [CPUID] instruction is available for our system, please enter the following command: ```PS> Get-CpuidIsAvailable``` or if you prefer, use its alias ```CPUID-Is-Available``` |
| 7 | In both cases, we must obtain ```True``` or ```False``` as a result, if this is so, perfect is already installed!! |
| 8 | Enjoy ;) | 

# Usage

## Examples

|Cmdlet|Alias|Description|Example(s)|
|:-----|:----|:----------|:---------|
| Get-CpuidIsAvailable | CPUID-Is-Available|Returns a value that indicates whether this system supports the [CPUID] instruction|[GetCpuidIsAvailable](./documentation/PowerShellCpuid.CmdLets/GetCpuidIsAvailableCmdlet.md) |
| Get-GetCpuidImplementedLeafs | CPUID-Implemented-Leafs|Returns a collection of elements where each element represents an implemented leaf|[GetCpuidImplementedLeafs](./documentation/PowerShellCpuid.CmdLets/GetCpuidImplementedLeafsCmdlet.md) |
| Get-CpuidSubLeafs|CPUID-Sub-Leafs | Returns all implemented sub-leafs for the given leaf|[GetCpuidSubLeafs](./documentation/PowerShellCpuid.CmdLets/GetCpuidSubLeafsCmdlet.md) |
| Get-CpuidImplementedProperties | CPUID-Implemented-Properties|Returns a collection of elements where each element represents an implemented property for given leaf, optionally you can specify the subleaf|[GetCpuidImplementedProperties](./documentation/PowerShellCpuid.CmdLets/GetCpuidImplementedPropertiesCmdlet.md) |
| Get-GetCpuidLocateProperty | CPUID-Locate-Property|Returns a value that contains the location or locations of the cpuid property by its name| [GetCpuidLocateProperty](./documentation/PowerShellCpuid.CmdLets/GetCpuidLocatePropertyCmdlet.md) |
| Get-GetCpuidProperty | CPUID-Property|Returns a reference that contains the information associated with the given property such as the key that identifies the property and its value|[GetCpuidProperty](./documentation/PowerShellCpuid.CmdLets/GetCpuidPropertyCmdlet.md) |
| Get-GetCpuidPropertyDetail | CPUID-Property-Detail|Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the property is expressed, description and leaf to which it belongs|[GetCpuidPropertyDetail](./documentation/PowerShellCpuid.CmdLets/GetCpuidPropertyDetailCmdlet.md) |

# Documentation

 - All available properties grouped by ```Leafs```, please see next link [properties_documentation].
 
 - For full code documentation, please see next link [full_documentation].

# How can I send feedback!!!

If you have found **iPowerShellCpuid** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iPowerShellCpuid**, please send me and email stating why this is so. I will use this feedback to improve **iPowerShellCpuid** in future releases.

My email address is 

![email.png][email] 

[email]: ./assets/email.png "email"
[CPUID]: https://github.com/iAJTin/iCPUID

[full_documentation]: ./documentation/iPowerShellCpuid.md
[properties_documentation]: ./documentation/iCPUID/Cpuid.AvailableLeafs.md

