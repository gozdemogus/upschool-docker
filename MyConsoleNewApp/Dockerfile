FROM mcr.microsoft.com/dotnet/runtime:3.1
#çalısma dizini
WORKDIR /app
COPY /bin/Release/netcoreapp3.1/publish /app/
ENTRYPOINT ["dotnet", "MyConsoleNewApp.dll"]
