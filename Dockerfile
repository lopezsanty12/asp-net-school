FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /home/app
COPY bin/Debug/net5.0/publish .

ENTRYPOINT ["dotnet", "Platzi-AspNet.dll"]