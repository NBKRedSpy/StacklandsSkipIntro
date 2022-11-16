Copy-Item ..\StacklandsSkipIntro\bin\Release\netstandard20\StacklandsSkipIntro.dll -Destination .
Copy-Item ..\README.md
Get-ChildItem -Exclude *.zip | Compress-Archive -Force -DestinationPath ./StacklandsSkipIntro.zip
