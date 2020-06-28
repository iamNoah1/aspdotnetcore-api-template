#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ASP.NetCore-API-Template/ASP.NetCore-API-Template.csproj", "ASP.NetCore-API-Template/"]
RUN dotnet restore "ASP.NetCore-API-Template/ASP.NetCore-API-Template.csproj"
COPY . .
WORKDIR "/src/ASP.NetCore-API-Template"
RUN dotnet build "ASP.NetCore-API-Template.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ASP.NetCore-API-Template.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ASP.NetCore-API-Template.dll"]