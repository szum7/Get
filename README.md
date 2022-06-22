Setup:

1. Edit the appsettings.json to your desired file location. (e.g.: "D:\\AllDocs\\testtxts\\test1.txt")
2. (optional) Set the ```<ToolCommandName>``` in the .csproj to the desired call name. (e.g.: a.get)
3. Build the solution
4. (cmd) ```cd``` to the solution root
5. (cmd) ```dotnet pack``` (pack up the program)
6. (cmd) ```cd``` to where the nupkg folder is located
7. (cmd) ```dotnet tool install -g --add-source ./nupkg get.cli``` (install the package globally)
8. Call the program from anywhere with an argument: ```a.get Foo```

Other useful commands:
- ```dotnet tool uninstall get.cli -g```
