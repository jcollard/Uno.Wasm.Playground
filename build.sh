#!/bin/bash
# FILES=$(find "SimpleProject" -type f -name "*.cs" | grep -v "SimpleProject/obj" | grep -v "SimpleProject/bin" | grep -v "SimpleProject/WebConsole")
# echo $FILES
rm -f WebProject/Program.cs || true
cp SimpleProject/Program.cs WebProject/Program.cs
sed -i 's/Console.ReadLine()/(await Console.ReadLine())/g' WebProject/Program.cs
sed -i 's/Thread.Sleep/await WebThread.Sleep/g' WebProject/Program.cs
rm -rf release
dotnet publish -c Release --output release App/App.csproj
rm release/App*
rm release/WebProject*