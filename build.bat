cd WebService
dotnet publish -c Release
cd..
docker build -t web-service .
