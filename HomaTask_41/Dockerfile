FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HomaTask_41/HomaTask_41.csproj", "HomaTask_41/"]
RUN dotnet restore "HomaTask_41/HomaTask_41.csproj"
COPY . .
WORKDIR "/src/HomaTask_41"
RUN dotnet build "HomaTask_41.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomaTask_41.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomaTask_41.dll"]
