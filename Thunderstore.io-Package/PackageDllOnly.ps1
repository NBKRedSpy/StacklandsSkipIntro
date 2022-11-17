$ProjectName = "StacklandsSkipIntro"
Copy-Item "..\$ProjectName\bin\Release\netstandard20\$ProjectName.dll" -Destination .
Compress-Archive -Path "$ProjectName.dll" -Force -DestinationPath ./$ProjectName.zip
