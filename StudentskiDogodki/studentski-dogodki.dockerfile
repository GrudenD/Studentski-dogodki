# Base image for runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Image for building
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy only the project file and restore dependencies
COPY ["StudentskiDogodki/StudentskiDogodki.csproj", "StudentskiDogodki/"]
RUN dotnet restore "./StudentskiDogodki/StudentskiDogodki.csproj"

# Copy the rest of the application code
COPY . .

WORKDIR "/src/StudentskiDogodki"
RUN dotnet build "StudentskiDogodki.csproj" -c Release -o /app/build

# Image for publishing
FROM build AS publish
RUN dotnet publish "StudentskiDogodki.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StudentskiDogodki.dll"]