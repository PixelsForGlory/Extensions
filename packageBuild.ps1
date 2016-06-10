$destinationFolder = "$env:STAGING_DIR\ReleaseContents\Plugins\"
if (!(Test-Path -path $destinationFolder)) {New-Item $destinationFolder -Type Directory}
Copy-Item $env:APPVEYOR_BUILD_FOLDER\Extensions\bin\Release\Extensions.dll -Destination $destinationFolder -Force 
