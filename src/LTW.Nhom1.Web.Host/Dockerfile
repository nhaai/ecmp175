FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/LTW.Nhom1.Web.Host/LTW.Nhom1.Web.Host.csproj", "src/LTW.Nhom1.Web.Host/"]
COPY ["src/LTW.Nhom1.Web.Core/LTW.Nhom1.Web.Core.csproj", "src/LTW.Nhom1.Web.Core/"]
COPY ["src/LTW.Nhom1.Application/LTW.Nhom1.Application.csproj", "src/LTW.Nhom1.Application/"]
COPY ["src/LTW.Nhom1.Core/LTW.Nhom1.Core.csproj", "src/LTW.Nhom1.Core/"]
COPY ["src/LTW.Nhom1.EntityFrameworkCore/LTW.Nhom1.EntityFrameworkCore.csproj", "src/LTW.Nhom1.EntityFrameworkCore/"]
WORKDIR "/src/src/LTW.Nhom1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LTW.Nhom1.Web.Host", "src/LTW.Nhom1.Web.Host"]
COPY ["src/LTW.Nhom1.Web.Core", "src/LTW.Nhom1.Web.Core"]
COPY ["src/LTW.Nhom1.Application", "src/LTW.Nhom1.Application"]
COPY ["src/LTW.Nhom1.Core", "src/LTW.Nhom1.Core"]
COPY ["src/LTW.Nhom1.EntityFrameworkCore", "src/LTW.Nhom1.EntityFrameworkCore"]
WORKDIR "/src/src/LTW.Nhom1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LTW.Nhom1.Web.Host.dll"]
