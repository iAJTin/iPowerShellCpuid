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

**Currently only works on windows**

# Install 

#### PowerShellGallery

 - Currently in progress...

#### Manually


|Step|Description|
|:------|:------|
|1|Create the ```iPowerShellCpuid``` folder in ```%programfiles%\WindowsPowerShell\Modules```|
|2|Copy the contents of the output folder ```Release``` or ```Debug``` into the folder created in the previous step. ```%programfiles%\WindowsPowerShell\Modules\iPowerShellCpuid```.|
|3|Run Windows PowerShell|
|4|For import **iPowerShellCpuid** module, please enter the following command: ```PS> Import-Module iPowerShellCpuid```|
|5|Now to check that everything is correct, let's check if the [CPUID] instruction is available for our system, please enter the following command: ```PS> Get-CpuidIsAvailable``` or if you prefer, use its alias ```CPUID-Is-Available```|
|6|In both cases, we must obtain ```True``` or ```False``` as a result, if this is so, perfect is already installed!!|
|7|Enjoy ;)| 

# Usage

## Examples

|Cmdlet|Alias|Description|Example(s)|
|:------|:------|:----------|
|Get-CpuidIsAvailable|CPUID-Is-Available|Returns a value that indicates whether this system supports the [CPUID] instruction|[GetCpuidIsAvailable](./documentation/PowerShellCpuid.CmdLets/GetCpuidIsAvailableCmdlet.md)|





|Get-GetCpuidImplementedLeafs|CPUID-Implemented-Leafs|Returns a collection of elements where each element represents an implemented leaf|[GetCpuidImplementedLeafs](./documentation/PowerShellCpuid.CmdLets/GetCpuidImplementedLeafsCmdlet.md)|
|Get-CpuidSubLeafs|CPUID-Sub-Leafs|Returns all implemented sub-leafs for the given leaf|[GetCpuidSubLeafs](./documentation/PowerShellCpuid.CmdLets/GetCpuidSubLeafsCmdlet.md)|
|Get-CpuidImplementedProperties|CPUID-Implemented-Properties|Returns a collection of elements where each element represents an implemented property for given leaf, optionally you can specify the subleaf|[CpuidImplementedProperties](./documentation/PowerShellCpuid.CmdLets/CpuidImplementedPropertiesCmdlet.md)|
|Get-GetCpuidLocateProperty|CPUID-Locate-Property|Returns a value that contains the location or locations of the cpuid property by its name| [GetCpuidLocateProperty](./documentation/PowerShellCpuid.CmdLets/GetCpuidLocatePropertyCmdlet.md)|
|Get-GetCpuidProperty|CPUID-Property|Returns a reference that contains the information associated with the given property such as the key that identifies the property and its value|[GetCpuidProperty](./documentation/PowerShellCpuid.CmdLets/GetCpuidPropertyCmdlet.md)|

## Library Documentation

 - For full code documentation, please see next link [documentation].

# How can I send feedback!!!

If you have found **iPowerShellCpuid** useful at work or in a personal project, I would love to hear about it. If you have decided not to use **iPowerShellCpuid**, please send me and email stating why this is so. I will use this feedback to improve **iPowerShellCpuid** in future releases.

My email address is 

![email.png][email] 

[email]: ./assets/email.png "email"
[CPUID]: https://github.com/iAJTin/iCPUID
[documentation]: ./documentation/iPowerShellCpuid.md

