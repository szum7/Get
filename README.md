Useful commands:

1. Edit the appsettings.json to your desired file location. (e.g.: "D:\\AllDocs\\testtxts\\test1.txt")
2. (optional) Set the ```<ToolCommandName>``` in the .csproj to the desired call name. (e.g.: a.get)
3. Build the solution
4. ```dotnet pack``` (pack up the program)
5. ```dotnet tool install -g --add-source ./nupkg get.cli``` (install the package globally)
6. Call the program from anywhere with an argument: ```a.get Foo```

Other useful commands:
- ```dotnet tool uninstall get.cli -g```
