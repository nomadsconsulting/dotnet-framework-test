FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY *.csproj ./
COPY *.config ./
RUN nuget restore

# copy everything else and build app
COPY . .
RUN msbuild /p:Configuration=Release /p:DeployOnBuild=true /p:PublishProfile=FolderProfile -r:False


FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/publish/. ./
