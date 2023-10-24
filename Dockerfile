FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o platform
COPY /src/VirtoCommerce.Platform.Web/modules /platform/modules

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /
COPY --from=build-env platform .
ENTRYPOINT ["dotnet", "VirtoCommerce.Platform.Web.dll"]
