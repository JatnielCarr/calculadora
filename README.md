# API de Cálculo de Áreas y Volúmenes

Esta API proporciona endpoints para calcular áreas y volúmenes de diferentes figuras geométricas.

## Características

- Cálculo de áreas:
  - Cuadrado
  - Rectángulo
  - Círculo
- Cálculo de volúmenes:
  - Cubo
  - Esfera
  - Cilindro

## Requisitos

- .NET 9.0 SDK o superior
- Visual Studio 2022 o Visual Studio Code

## Instalación

1. Clona el repositorio:
```bash
git clone [URL_DEL_REPOSITORIO]
```

2. Navega al directorio del proyecto:
```bash
cd AREASYVOLUMENES
```

3. Restaura las dependencias:
```bash
dotnet restore
```

4. Ejecuta el proyecto:
```bash
dotnet run
```

## Uso

La API estará disponible en `https://localhost:5001` o `http://localhost:5000`.

### Documentación Swagger

La documentación interactiva de la API está disponible en:
- `/swagger` - Interfaz de Swagger UI
- `/swagger/v1/swagger.json` - Especificación OpenAPI

### Endpoints

#### Áreas

- `GET /api/Geometria/area/cuadrado?lado={valor}`
- `GET /api/Geometria/area/rectangulo?base_={valor}&altura={valor}`
- `GET /api/Geometria/area/circulo?radio={valor}`

#### Volúmenes

- `GET /api/Geometria/volumen/cubo?lado={valor}`
- `GET /api/Geometria/volumen/esfera?radio={valor}`
- `GET /api/Geometria/volumen/cilindro?radio={valor}&altura={valor}`

## Contribución

1. Haz un Fork del proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.

## Compatibilidad de versiones .NET

Este proyecto está configurado para funcionar con múltiples versiones de .NET:

- **Desarrollo local:** .NET 9.0 (preview)
- **Despliegue en Railway:** .NET 8.0

Railway solo soporta hasta .NET 8.0 actualmente. Gracias al multi-targeting, puedes trabajar localmente con .NET 9.0 y desplegar sin problemas en Railway.

No necesitas cambiar nada para desplegar, Railway detectará automáticamente la versión compatible. 