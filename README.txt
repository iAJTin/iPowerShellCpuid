
What is iPowerShellCpuid?
=========================

iPowerShellCpuid contains a collection of PowerShell Cmdlets that allow us to obtain the CPUID information. 


v1.0.0
======

Added

 - Library versions for this version

-------------------------------------------------------------------------------------------------
| Library                                   Version       Description                           |
-------------------------------------------------------------------------------------------------
| iPowerShellCpuid                          1.0.0.0       CPUID PowerShell Cmdlets library      |
-------------------------------------------------------------------------------------------------

- Solution structure, prepare solution structure to add future new specifications.

      \ root
        \ documentation       [Code documentation (md files)]
        \ references          [External references]
        \ src
          \ iPowerShellCpuid  [CPUID PowerShell Cmdlets library] 
        \ tools               [Build documentation script]


Install via PowerShellGallery
=============================

In progress..


Usage
=====

Examples
--------

- Below are a series of tabs with shortcuts and information on all available cmdlets.

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-CpuidIsAvailable                                                                                                                             |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-CpuidIsAvailable                                                                                                           |
| Alias             CPUID-Is-Available                                                                                                             |
| Description       Returns a value that indicates whether this system supports the CPUID instruction.                                             |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/GetCpuidIsAvailableCmdlet.md        |
----------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetCpuidImplementedLeafs                                                                                                                     |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-GetCpuidImplementedLeafs                                                                                                   |
| Alias             CPUID-Implemented-Leafs                                                                                                        |
| Description       Returns a collection of elements where each element represents an implemented leaf.                                            |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/GetCpuidImplementedLeafsCmdlet.md   |
----------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-CpuidSubLeafs                                                                                                                                |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-CpuidSubLeafs                                                                                                              |
| Alias             CPUID-Sub-Leafs                                                                                                                |
| Description       Returns all implemented sub-leafs for the given leaf.                                                                          |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/GetCpuidSubLeafsCmdlet.md           |
----------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-CpuidImplementedProperties                                                                                                                   |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-CpuidImplementedProperties                                                                                                 |
| Alias             CPUID-Implemented-Properties                                                                                                   |
| Description       Returns a collection of elements where each element represents an implemented property for given leaf, optionally you can      |
|                   specify the subleaf.                                                                                                           |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/CpuidImplementedPropertiesCmdlet.md |
----------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetCpuidLocateProperty                                                                                                                       |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-CpuidImplementedProperties                                                                                                 |
| Alias             CPUID-Locate-Property                                                                                                          |
| Description       Returns a value that contains the location or locations of the cpuid property by its name.                                     |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/GetCpuidLocatePropertyCmdlet.md     |
----------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetCpuidProperty                                                                                                                             |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-GetCpuidProperty                                                                                                           |
| Alias             CPUID-Property                                                                                                                 |
| Description       Returns a reference that contains the information associated with the given property such as the key that identifies the       |
|                   property and its value.                                                                                                        |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/GetCpuidPropertyCmdlet.md           |
----------------------------------------------------------------------------------------------------------------------------------------------------

----------------------------------------------------------------------------------------------------------------------------------------------------
| Get-GetCpuidPropertyDetail                                                                                                                       |
----------------------------------------------------------------------------------------------------------------------------------------------------
| Name              Get-GetCpuidPropertyDetail                                                                                                     |
| Alias             CPUID-Property-Detail                                                                                                          |
| Description       Returns a reference that contains the complete data of the given property, includes its name, value, unit in which the         |
|                   property is expressed, description and leaf to which it belongs.                                                               |
| Example(s) link   https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/PowerShellCpuid.CmdLets/GetCpuidPropertyCmdlet.md           |
----------------------------------------------------------------------------------------------------------------------------------------------------

Library Documentation
---------------------

For full code documentation, please see https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/iPowerShellCpuid.md
