# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copia los archivos del proyecto y restaura dependencias
COPY . ./
RUN dotnet restore --use-current-runtime
RUN dotnet publish -c Release -o out

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Puerto por defecto para ASP.NET Core
EXPOSE 80

ENTRYPOINT ["dotnet", "AREASYVOLUMENES.dll"]