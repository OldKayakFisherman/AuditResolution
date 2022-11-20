FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/services/AuditImportService/AuditImportService.csproj", "AuditImportService/"]
RUN dotnet restore "src/services/AuditImportService/AuditImportService.csproj"
COPY . .
WORKDIR "/src/AuditImportService"
RUN dotnet build "AuditImportService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AuditImportService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AuditImportService.dll"]
