@ECHO OFF
CLS

rmdir ..\documentation /s /q

xmldocmd ..\src\iPowerShellCpuid\bin\Release\iPowerShellCpuid.dll ..\documentation

PAUSE