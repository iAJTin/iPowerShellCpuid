$releasePath = Join-Path $PSScriptRoot "bin\Release"
$modulePath = Join-Path $PSScriptRoot "bin\iPowerShellCpuid"

Write-Host "Preparing module"

# Moverse a la carpeta de la versión elegida y ejecutar el comando.
# Ex. versión 1.0.0.0 -> cd ...iPowerShellCpuid\deployment\v1.0.0.0
# Cuando solicite ApiKey introducir clave
Publish-Module -Path .\iPowerShellCpuid -Repository PSGallery -NuGetApiKey (Read-Host "NuGetApiKey (from https://powershellgallery.com/account)") -verbose
