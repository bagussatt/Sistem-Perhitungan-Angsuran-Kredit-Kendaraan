# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Salin file proyek dan restore dependencies
COPY ["IMSApp.csproj", "./"]
RUN dotnet restore "IMSApp.csproj"
# Salin sisa file dan publish
COPY . .
RUN dotnet publish "IMSApp.csproj" -c Release -o /app/publish

# Stage 2: Run
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
# PASTIKAN nama file .dll ini sama dengan nama project Anda
ENTRYPOINT ["dotnet", "IMSApp.dll"]