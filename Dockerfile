FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY WebService/bin/Release/net5.0/publish ./
ENTRYPOINT ["dotnet", "WebService.dll"]

# Run these commands in a command prompt to build the docker image
# cd WebService
# dotnet publish -c Release
# cd..
# docker build -t web-service .
