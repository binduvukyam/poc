FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder
WORKDIR /src

COPY ./s2/s2.csproj .
RUN dotnet restore s2/s2.csproj
COPY . .
RUN dotnet build s2.csproj -c Debug -o /src/out/s2

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=builder /src/out/s2 .

EXPOSE 80
ENTRYPOINT ["dotnet", "s2.dll"]