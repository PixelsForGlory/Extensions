# Run unit test
Copy-Item $env:APPVEYOR_BUILD_FOLDER\Extensions\bin\Release\Extensions.* -Destination $env:APPVEYOR_BUILD_FOLDER\ExtensionsTest\bin\Release\ -Force
vstest.console $env:APPVEYOR_BUILD_FOLDER\ExtensionsTest\bin\Release\ExtensionsTest.dll /Settings:$env:APPVEYOR_BUILD_FOLDER\ExtensionsTest\test.runsettings /logger:Appveyor
if ($LastExitCode -ne 0) { $host.SetShouldExit($LastExitCode)  }