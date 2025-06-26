using Microsoft.AspNetCore.Mvc;
using AREASYVOLUMENES.Services;
using AREASYVOLUMENES.Models;
using Microsoft.AspNetCore.Authorization;

namespace AREASYVOLUMENES.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class GeometriaController : ControllerBase
    {
        private readonly ICalculoService _calculoService;
        public GeometriaController(ICalculoService calculoService)
        {
            _calculoService = calculoService;
        }

        [HttpGet("area/cuadrado")]
        public IActionResult CalcularAreaCuadrado(double lado)
        {
            if (lado <= 0)
                return BadRequest("El lado debe ser mayor que 0");
            var area = _calculoService.CalculateSquareArea(lado);
            _calculoService.GuardarResultadoArea("cuadrado", area, lado.ToString());
            return Ok(new { area });
        }

        [HttpGet("area/rectangulo")]
        public IActionResult CalcularAreaRectangulo(double base_, double altura)
        {
            if (base_ <= 0 || altura <= 0)
                return BadRequest("La base y la altura deben ser mayores que 0");
            var area = _calculoService.CalculateRectangleArea(base_, altura);
            _calculoService.GuardarResultadoArea("rectangulo", area, $"{base_},{altura}");
            return Ok(new { area });
        }

        [HttpGet("area/circulo")]
        public IActionResult CalcularAreaCirculo(double radio)
        {
            if (radio <= 0)
                return BadRequest("El radio debe ser mayor que 0");
            var area = _calculoService.CalculateCircleArea(radio);
            _calculoService.GuardarResultadoArea("circulo", area, radio.ToString());
            return Ok(new { area });
        }

        [HttpGet("volumen/cubo")]
        public IActionResult CalcularVolumenCubo(double lado)
        {
            if (lado <= 0)
                return BadRequest("El lado debe ser mayor que 0");
            var volumen = lado * lado * lado;
            _calculoService.GuardarResultadoVolumen("cubo", volumen, lado.ToString());
            return Ok(new { volumen });
        }

        [HttpGet("volumen/esfera")]
        public IActionResult CalcularVolumenEsfera(double radio)
        {
            if (radio <= 0)
                return BadRequest("El radio debe ser mayor que 0");
            var volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
            _calculoService.GuardarResultadoVolumen("esfera", volumen, radio.ToString());
            return Ok(new { volumen });
        }

        [HttpGet("volumen/cilindro")]
        public IActionResult CalcularVolumenCilindro(double radio, double altura)
        {
            if (radio <= 0 || altura <= 0)
                return BadRequest("El radio y la altura deben ser mayores que 0");
            var volumen = Math.PI * radio * radio * altura;
            _calculoService.GuardarResultadoVolumen("cilindro", volumen, $"{radio},{altura}");
            return Ok(new { volumen });
        }

        [HttpGet("perimetro/cuadrado")]
        public IActionResult CalcularPerimetroCuadrado(double lado)
        {
            if (lado <= 0)
                return BadRequest("El lado debe ser mayor que 0");
            var perimetro = _calculoService.CalcularPerimetroCuadrado(lado);
            _calculoService.GuardarResultadoPerimetro("cuadrado", perimetro, lado.ToString());
            return Ok(new { perimetro });
        }

        [HttpGet("perimetro/rectangulo")]
        public IActionResult CalcularPerimetroRectangulo(double base_, double altura)
        {
            if (base_ <= 0 || altura <= 0)
                return BadRequest("La base y la altura deben ser mayores que 0");
            var perimetro = _calculoService.CalcularPerimetroRectangulo(base_, altura);
            _calculoService.GuardarResultadoPerimetro("rectangulo", perimetro, $"{base_},{altura}");
            return Ok(new { perimetro });
        }

        [HttpGet("perimetro/circulo")]
        public IActionResult CalcularPerimetroCirculo(double radio)
        {
            if (radio <= 0)
                return BadRequest("El radio debe ser mayor que 0");
            var perimetro = _calculoService.CalcularPerimetroCirculo(radio);
            _calculoService.GuardarResultadoPerimetro("circulo", perimetro, radio.ToString());
            return Ok(new { perimetro });
        }
    }
} 