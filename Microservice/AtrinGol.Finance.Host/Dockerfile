FROM mcr.microsoft.com/dotnet/core/aspnet:7.0-bullseye-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:7.0 AS build
WORKDIR /src
COPY . .
WORKDIR /src/templates/service/host/AtrinGol.Finance.HttpApi.Host
RUN dotnet restore -nowarn:msb3202,nu1503
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AtrinGol.Finance.HttpApi.Host.dll"]