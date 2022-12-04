FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy everything
COPY *.csproj ./
RUN dotnet restore

# Build and publish a release
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app/publish
EXPOSE 8080
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "maguro.dll"]