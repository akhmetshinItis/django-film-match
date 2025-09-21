FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["../SocialNetwork/FilmMatch.csproj", "SocialNetwork/"]
COPY ["../S3/S3.csproj", "S3/"]
COPY ["../SocialNetwork.Application/FilmMatch.Application.csproj", "SocialNetwork.Application/"]
COPY ["../SocialNetwork.Domain/FilmMatch.Domain.csproj", "SocialNetwork.Domain/"]
COPY ["../SocialNetwork.Infrastructure/FilmMatch.Infrastructure.csproj", "SocialNetwork.Infrastructure/"]
COPY ["../SocialNetwork.Persistence/FilmMatch.Persistence.csproj", "SocialNetwork.Persistence/"]
RUN dotnet restore "SocialNetwork/FilmMatch.csproj"
COPY . .
WORKDIR "/src/SocialNetwork"
RUN dotnet build "FilmMatch.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FilmMatch.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FilmMatch.dll"]
