# Build stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["StudentskiDogodki/StudentskiDogodki.csproj", "StudentskiDogodki/"]
RUN dotnet restore "StudentskiDogodki/StudentskiDogodki.csproj"

COPY . .
WORKDIR "/src/StudentskiDogodki"
RUN dotnet build "StudentskiDogodki.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StudentskiDogodki.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "StudentskiDogodki.dll"]