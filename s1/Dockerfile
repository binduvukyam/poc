FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder
WORKDIR /src

COPY ./s1/s1.csproj .
RUN dotnet restore s1/s1.csproj
COPY . .
RUN dotnet build s1.csproj -c Debug -o /src/out/s1

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=builder /src/out/s1 .

EXPOSE 80
ENTRYPOINT ["dotnet", "s1.dll"]
