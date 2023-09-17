FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HomeTask_42/HomeTask_42.csproj", "HomeTask_42/"]
RUN dotnet restore "HomeTask_42/HomeTask_42.csproj"
COPY . .
WORKDIR "/src/HomeTask_42"
RUN dotnet build "HomeTask_42.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeTask_42.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeTask_42.dll"]
