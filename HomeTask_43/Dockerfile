FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["HomeTask_43/HomeTask_43.csproj", "HomeTask_43/"]
RUN dotnet restore "HomeTask_43/HomeTask_43.csproj"
COPY . .
WORKDIR "/src/HomeTask_43"
RUN dotnet build "HomeTask_43.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HomeTask_43.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HomeTask_43.dll"]
