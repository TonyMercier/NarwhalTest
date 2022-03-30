#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NarwhalTest.Api/NarwhalTest.Api.csproj", "NarwhalTest.Api/"]
COPY ["NarwhalTest.Application/NarwhalTest.Application.csproj", "NarwhalTest.Application/"]
COPY ["NarwhalTest.Extensions.IEnumerable/NarwhalTest.Extensions.IEnumerable.csproj", "NarwhalTest.Extensions.IEnumerable/"]
COPY ["NarwhalTest.Domain/NarwhalTest.Domain.csproj", "NarwhalTest.Domain/"]
COPY ["NarwhalTest.Extensions.Number/NarwhalTest.Extensions.Number.csproj", "NarwhalTest.Extensions.Number/"]
COPY ["NarwhalTest.Persistence/NarwhalTest.Persistence.csproj", "NarwhalTest.Persistence/"]
COPY ["NarwhalTest.NarwhalServiceClient/NarwhalTest.NarwhalServiceClient.csproj", "NarwhalTest.NarwhalServiceClient/"]
RUN dotnet restore "NarwhalTest.Api/NarwhalTest.Api.csproj"
COPY . .
WORKDIR "/src/NarwhalTest.Api"
RUN dotnet build "NarwhalTest.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NarwhalTest.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NarwhalTest.Api.dll"]