FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /webapp

# Copy everything
COPY . ./
# Install dependencies
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /webapp
COPY --from=build-env /webapp/out .
ENV ASPNETCORE_URLS=http://+:3012
ENTRYPOINT ["dotnet", "DotNetIntro.Docker.dll"]

EXPOSE 3012