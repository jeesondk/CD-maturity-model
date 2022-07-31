FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CDMM/CDMM.csproj", "CDMM/"]
RUN dotnet restore "CDMM/CDMM.csproj"
COPY . .
WORKDIR "/src/CDMM"
RUN dotnet build "CDMM.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CDMM.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CDMM.dll"]
