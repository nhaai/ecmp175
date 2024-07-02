FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/LTW.Nhom1.Web.Mvc/LTW.Nhom1.Web.Mvc.csproj", "src/LTW.Nhom1.Web.Mvc/"]
COPY ["src/LTW.Nhom1.Web.Core/LTW.Nhom1.Web.Core.csproj", "src/LTW.Nhom1.Web.Core/"]
COPY ["src/LTW.Nhom1.Application/LTW.Nhom1.Application.csproj", "src/LTW.Nhom1.Application/"]
COPY ["src/LTW.Nhom1.Core/LTW.Nhom1.Core.csproj", "src/LTW.Nhom1.Core/"]
COPY ["src/LTW.Nhom1.EntityFrameworkCore/LTW.Nhom1.EntityFrameworkCore.csproj", "src/LTW.Nhom1.EntityFrameworkCore/"]
WORKDIR "/src/src/LTW.Nhom1.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LTW.Nhom1.Web.Mvc", "src/LTW.Nhom1.Web.Mvc"]
COPY ["src/LTW.Nhom1.Web.Core", "src/LTW.Nhom1.Web.Core"]
COPY ["src/LTW.Nhom1.Application", "src/LTW.Nhom1.Application"]
COPY ["src/LTW.Nhom1.Core", "src/LTW.Nhom1.Core"]
COPY ["src/LTW.Nhom1.EntityFrameworkCore", "src/LTW.Nhom1.EntityFrameworkCore"]
WORKDIR "/src/src/LTW.Nhom1.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LTW.Nhom1.Web.Mvc.dll"]
