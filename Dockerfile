FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine3.11 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine3.11 AS build
WORKDIR /src
COPY ["ConsoleGenericStrategy/ConsoleGenericStrategy.csproj", "ConsoleGenericStrategy/"]
RUN dotnet restore "ConsoleGenericStrategy/ConsoleGenericStrategy.csproj"
COPY . .
WORKDIR "/src/ConsoleGenericStrategy"
RUN dotnet build "ConsoleGenericStrategy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleGenericStrategy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleGenericStrategy.dll"]