# syntax=docker/dockerfile:1

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:10.0 AS restore
ARG TARGETARCH
WORKDIR /src

COPY devops_backend.csproj .
RUN dotnet restore devops_backend.csproj -a $TARGETARCH

FROM restore AS build
COPY . .
RUN dotnet build devops_backend.csproj -c Release --no-restore -a $TARGETARCH

FROM build AS publish
ARG TARGETARCH
RUN dotnet publish devops_backend.csproj -c Release --no-restore -a $TARGETARCH -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080 \
    ASPNETCORE_ENVIRONMENT=Production
COPY --from=publish /app/publish .
USER $APP_UID
ENTRYPOINT ["dotnet", "devops_backend.dll"]