# Build stage
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src

COPY ["DockerGruden/AIS naloga 3 Drejc_gruden", "DockerGruden/"]
RUN dotnet restore "DockerGruden/AIS naloga 3 Drejc_gruden.csproj"

COPY . .
WORKDIR "/src/DockerGruden"
RUN dotnet build "AIS naloga 3 Drejc_gruden.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AIS naloga 3 Drejc_gruden.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "AIS naloga 3 Drejc_gruden.dll"]