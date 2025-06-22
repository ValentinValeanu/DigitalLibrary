# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY ["DigitalLibraryWebAPI.sln", "./"]
COPY ["DigitalLibrary.API/DigitalLibrary.API.csproj", "DigitalLibrary.API/"]
COPY ["DigitalLibrary.Data/DigitalLibrary.Data.csproj", "DigitalLibrary.Data/"]
COPY ["DigitalLibrary.Services/DigitalLibrary.Services.csproj", "DigitalLibrary.Services/"]
RUN dotnet restore

COPY . .

WORKDIR /src/DigitalLibrary.API
RUN dotnet publish -c Release -o /app

# Stage 2: Runtime

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

COPY --from=build /app .

ENTRYPOINT ["dotnet", "DigitalLibrary.API.dll"]
