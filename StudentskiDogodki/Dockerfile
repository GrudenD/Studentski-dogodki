# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["StudentskiDogodki/StudentskiDogodki.csproj", "StudentskiDogodki/"]
RUN dotnet restore "StudentskiDogodki/StudentskiDogodki.csproj"

# Copy the source code
COPY . .

# Build the application
WORKDIR "/src/StudentskiDogodki"
RUN dotnet build "StudentskiDogodki.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "StudentskiDogodki.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app

# Copy the published output from the build stage
COPY --from=publish /app/publish .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "StudentskiDogodki.dll"]