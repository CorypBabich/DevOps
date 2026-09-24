# syntax=docker/dockerfile:1

#FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS restore
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8
ARG TARGETARCH
WORKDIR /src

#COPY DevOps.csproj .
#RUN dotnet restore DevOps.csproj -a $TARGETARCH

FROM restore AS build
COPY . .
RUN msbuild DevOps.csproj -c Release --no-restore -a $TARGETARCH

FROM build AS publish
ARG TARGETARCH
RUN mspublish DevOps.csproj -c Release --no-restore -a $TARGETARCH -o /app/publish

FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS final
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080 \
    ASPNETCORE_ENVIRONMENT=Production
COPY --from=publish /app/publish .
USER $APP_UID
ENTRYPOINT ["dotnet", "devops_frontend.dll"]