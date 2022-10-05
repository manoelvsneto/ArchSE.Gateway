FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ArchSE.Gateway.csproj", "./"]
RUN dotnet restore "ArchSE.Gateway.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "ArchSE.Gateway.csproj" -c Release -o /app/build
FROM build AS publish
RUN dotnet publish "ArchSE.Gateway.csproj" -c Release -o /app/publish
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:8090
ENTRYPOINT ["dotnet", "ArchSE.Gateway.dll"]