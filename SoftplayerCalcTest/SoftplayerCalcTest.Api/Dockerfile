FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["SoftplayerCalcTest.Api/SoftplayerCalcTest.Api.csproj", "SoftplayerCalcTest.Api/"]
COPY ["SoftplayerCalcTest.Domain/SoftplayerCalcTest.Domain.csproj", "SoftplayerCalcTest.Domain/"]
RUN dotnet restore "SoftplayerCalcTest.Api/SoftplayerCalcTest.Api.csproj"
COPY . .
WORKDIR "/src/SoftplayerCalcTest.Api"
RUN dotnet build "SoftplayerCalcTest.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SoftplayerCalcTest.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SoftplayerCalcTest.Api.dll"]