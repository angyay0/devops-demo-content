FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as buildenv
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=buildenv /app/out .
ENTRYPOINT ["dotnet", "contentapi.dll"]