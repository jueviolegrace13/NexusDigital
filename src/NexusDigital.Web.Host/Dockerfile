FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/NexusDigital.Web.Host/NexusDigital.Web.Host.csproj", "src/NexusDigital.Web.Host/"]
COPY ["src/NexusDigital.Web.Core/NexusDigital.Web.Core.csproj", "src/NexusDigital.Web.Core/"]
COPY ["src/NexusDigital.Application/NexusDigital.Application.csproj", "src/NexusDigital.Application/"]
COPY ["src/NexusDigital.Core/NexusDigital.Core.csproj", "src/NexusDigital.Core/"]
COPY ["src/NexusDigital.EntityFrameworkCore/NexusDigital.EntityFrameworkCore.csproj", "src/NexusDigital.EntityFrameworkCore/"]
WORKDIR "/src/src/NexusDigital.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/NexusDigital.Web.Host", "src/NexusDigital.Web.Host"]
COPY ["src/NexusDigital.Web.Core", "src/NexusDigital.Web.Core"]
COPY ["src/NexusDigital.Application", "src/NexusDigital.Application"]
COPY ["src/NexusDigital.Core", "src/NexusDigital.Core"]
COPY ["src/NexusDigital.EntityFrameworkCore", "src/NexusDigital.EntityFrameworkCore"]
WORKDIR "/src/src/NexusDigital.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "NexusDigital.Web.Host.dll"]
