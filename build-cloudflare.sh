#!/bin/sh
curl -sSL https://dot.net/v1/dotnet-install.sh > dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh -c 8.0 --version 8.0.100-rc.1.23463.5 -InstallDir ./dotnet
./dotnet/dotnet --version
./dotnet/dotnet workload restore
./dotnet/dotnet workload list
./dotnet/dotnet publish ./src/MattParkerDev.WebUI/MattParkerDev.WebUI.csproj -c Release -o output