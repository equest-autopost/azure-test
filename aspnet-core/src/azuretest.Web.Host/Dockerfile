# FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# WORKDIR /src
# COPY ["src/azuretest.Web.Host/azuretest.Web.Host.csproj", "src/azuretest.Web.Host/"]
# COPY ["src/azuretest.Web.Core/azuretest.Web.Core.csproj", "src/azuretest.Web.Core/"]
# COPY ["src/azuretest.Application/azuretest.Application.csproj", "src/azuretest.Application/"]
# COPY ["src/azuretest.Core/azuretest.Core.csproj", "src/azuretest.Core/"]
# COPY ["src/azuretest.EntityFrameworkCore/azuretest.EntityFrameworkCore.csproj", "src/azuretest.EntityFrameworkCore/"]
# WORKDIR "/src/src/azuretest.Web.Host"
# RUN dotnet restore 

# WORKDIR /src
# COPY ["src/azuretest.Web.Host", "src/azuretest.Web.Host"]
# COPY ["src/azuretest.Web.Core", "src/azuretest.Web.Core"]
# COPY ["src/azuretest.Application", "src/azuretest.Application"]
# COPY ["src/azuretest.Core", "src/azuretest.Core"]
# COPY ["src/azuretest.EntityFrameworkCore", "src/azuretest.EntityFrameworkCore"]
# WORKDIR "/src/src/azuretest.Web.Host"
# RUN dotnet publish -c Release -o /publish --no-restore

# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# EXPOSE 80
# WORKDIR /app
# COPY --from=build /publish .
# ENTRYPOINT ["dotnet", "azuretest.Web.Host.dll"]
