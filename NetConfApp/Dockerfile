FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["NetConfApp/NetConfApp.csproj", "NetConfApp/"]
RUN dotnet restore "NetConfApp/NetConfApp.csproj"
COPY . .
WORKDIR "/src/NetConfApp"
RUN dotnet build "NetConfApp.csproj" -c Release -o /app/build

RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs

FROM build AS publish
RUN dotnet publish "NetConfApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NetConfApp.dll"]