#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Channel.API/Channel.API.csproj", "Channel.API/"]
COPY ["Channel.Model/Channel.Model.csproj", "Channel.Model/"]
COPY ["Channel.Service/Channel.Repository.csproj", "Channel.Service/"]
COPY ["Channel.Domain/Channel.Domain.csproj", "Channel.Domain/"]
COPY ["Common/Common.csproj", "Common/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["Services/Services.csproj", "Services/"]

RUN dotnet restore "Channel.API/Channel.API.csproj"
COPY . .
WORKDIR "/src/Channel.API"
RUN dotnet build "Channel.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Channel.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Channel.API.dll"]