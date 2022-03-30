Get-AppxPackage microsoft.windowscommunicationsapps  | Remove-AppxPackage
Start-Sleep -Seconds 3
Get-AppXPackage -AllUsers microsoft.windowscommunicationsapps | Foreach {Add-AppxPackage -DisableDevelopmentMode -Register "$($_.InstallLocation)\AppXManifest.xml" }
