#
# Manifiesto del módulo 'iPowerShellCpuid'
#
# Generado por iTin
#
# Generado el 15/10/2020
#

@{

# Módulo de script o archivo de módulo binario asociado con este manifiesto.
RootModule = 'iPowerShellCpuid.dll'

# Número de versión de este módulo.
ModuleVersion = '1.0.0'

# PSEditions compatibles
# CompatiblePSEditions = @()

# Id. usado para identificar de forma única este módulo.
GUID = 'eb8bbe35-ecff-452a-8f2c-7a4dda59a402'

# Autor de este módulo.
Author = 'iTin'

# Compañía o proveedor de este módulo.
CompanyName = 'iTin'

# Instrucción de copyright de este módulo.
Copyright = '(c) 2020 iTin. Licensed under MIT Licence.'

# Descripción de la funcionalidad proporcionada por este módulo.
Description = 'PowerShell Cmdlets for CPUID instruction'

# Versión mínima del motor de Windows PowerShell requerida por este módulo.
PowerShellVersion = '4.0'

# El nombre del host de Windows PowerShell requerido por este módulo.
# PowerShellHostName = ''

# Versión mínima del host de Windows PowerShell requerida por este módulo.
# PowerShellHostVersion = ''

# Versión mínima de Microsoft .NET Framework requerida por este módulo. Este requisito previo únicamente es válido para la edición de escritorio de PowerShell.
DotNetFrameworkVersion = '4.6.1'

# Versión mínima de Common Language Runtime (CLR) requerida por este módulo. Este requisito previo únicamente es válido para la edición de escritorio de PowerShell.
CLRVersion = '4.0'

# Arquitectura de procesador (None, X86, Amd64) que requiere este módulo
# ProcessorArchitecture = ''

# Módulos que se deben importar en el entorno global antes de importar este módulo.
# RequiredModules = @()

# Ensamblados que se deben cargar antes de importar este módulo.
# RequiredAssemblies = @()

# Archivos de script (.ps1) que se ejecutan en el entorno del llamador antes de importar este módulo.
# ScriptsToProcess = @()

# Archivos de tipo (.ps1xml) que se van a cargar al importar este módulo.
# TypesToProcess = @()

# Archivos de formato (.ps1xml) que se van a cargar al importar este módulo.
# FormatsToProcess = @()

# Módulos para importar como módulos anidados del módulo especificado en RootModule/ModuleToProcess
# NestedModules = @()

# Funciones para exportar desde este módulo; para conseguir el mejor rendimiento, no uses caracteres comodines ni elimines la entrada; usa una matriz vacía si no hay funciones que exportar.
FunctionsToExport = '*'

# Cmdlets para exportar desde este módulo; para conseguir el mejor rendimiento, no uses caracteres comodines ni elimines la entrada; usa una matriz vacía si no hay cmdlets que exportar.
CmdletsToExport = 'Get-CpuidImplementedProperties', 'Get-CpuidImplementedLeafs', 
    'Get-CpuidProperty' ,'Get-CpuidLocateProperty', 
    'Get-CpuidSubLeafs', 'Get-CpuidIsAvailable'

# Variables para exportar desde este módulo.
VariablesToExport = '*'

# Alias para exportar desde este módulo; para conseguir el mejor rendimiento, no uses caracteres comodines ni elimines la entrada; usa una matriz vacía si no hay alias que exportar.
AliasesToExport = 'CPUID-Implemented-Properties', 'CPUID-Implemented-Leafs',
    'CPUID-Property', 'CPUID-Locate-Property',
    'CPUID-Sub-Leafs', 'CPUID-Is-Available'

# Recursos de DSC que se exportarán de este módulo
# DscResourcesToExport = @()

# Lista de todos los módulos empaquetados con este módulo
# ModuleList = @()

# Lista de todos los paquetes con este módulo.
# FileList = @()

# Datos privados que se pasan al módulo especificado en RootModule/ModuleToProcess. Pueden contener también una tabla hash PSData con metadatos del módulo adicionales usados por PowerShell.
PrivateData = @{

    PSData = @{

        # Etiquetas aplicadas a este módulo. Ayudan a encontrar el módulo en las galerías en línea.
        Tags = @('cpu', 'hardware', 'cpuid', 'leafs', 'iTin', 'cpuid-information')

        # Dirección URL a la licencia de este módulo.
        LicenseUri = 'https://github.com/iAJTin/iPowerShellCpuid/blob/main/LICENSE'

        # Una dirección URL al sitio web principal de este proyecto.
        ProjectUri = 'https://github.com/iAJTin/iPowerShellCpuid'

        # Una dirección URL a un icono que representa este módulo.
        IconUri = 'https://github.com/iAJTin/iPowerShellCpuid/blob/main/powershellgallery/iPowerShellCpuid.png'

        # ReleaseNotes de este módulo
        ReleaseNotes = 'iPowerShellCpuid contains a collection of PowerShell Cmdlets that allow us to obtain the CPUID information.'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()
    }
} 

# URI de HelpInfo de este módulo
HelpInfoURI = 'https://github.com/iAJTin/iPowerShellCpuid/blob/main/documentation/iPowerShellCpuid.md'

# Prefijo predeterminado para los comandos exportados desde este módulo. Invalide el prefijo predeterminado mediante Import-Module -Prefix.
# DefaultCommandPrefix = ''

}
