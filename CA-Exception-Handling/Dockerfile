FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CA-Exception-Handling/CA-Exception-Handling.csproj", "CA-Exception-Handling/"]
RUN dotnet restore "CA-Exception-Handling/CA-Exception-Handling.csproj"
COPY . .
WORKDIR "/src/CA-Exception-Handling"
RUN dotnet build "CA-Exception-Handling.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "CA-Exception-Handling.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CA-Exception-Handling.dll"]
