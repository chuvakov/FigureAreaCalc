FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FigureAreaCalcWebApi/FigureAreaCalcWebApi.csproj", "FigureAreaCalcWebApi/"]
RUN dotnet restore "FigureAreaCalcWebApi/FigureAreaCalcWebApi.csproj"
COPY . .
WORKDIR "/src/FigureAreaCalcWebApi"
RUN dotnet build "FigureAreaCalcWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FigureAreaCalcWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FigureAreaCalcWebApi.dll"]
