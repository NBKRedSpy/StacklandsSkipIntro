$ProjectName = "StacklandsSkipIntro"
Copy-Item "..\$ProjectName\bin\Release\netstandard20\$ProjectName.dll" -Destination .
Copy-Item ..\README.md
Get-ChildItem -Exclude *.zip,*.ps1 | Compress-Archive -Force -DestinationPath ./$ProjectName.zip
