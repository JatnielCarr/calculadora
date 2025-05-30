using Microsoft.AspNetCore.Mvc;

namespace AREASYVOLUMENES.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeometriaController : ControllerBase
    {
        [HttpGet("area/cuadrado")]
        public IActionResult CalcularAreaCuadrado(double lado)
        {
            if (lado <= 0)
                return BadRequest("El lado debe ser mayor que 0");

            var area = lado * lado;
            return Ok(new { area });
        }

        [HttpGet("area/rectangulo")]
        public IActionResult CalcularAreaRectangulo(double base_, double altura)
        {
            if (base_ <= 0 || altura <= 0)
                return BadRequest("La base y la altura deben ser mayores que 0");

            var area = base_ * altura;
            return Ok(new { area });
        }

        [HttpGet("area/circulo")]
        public IActionResult CalcularAreaCirculo(double radio)
        {
            if (radio <= 0)
                return BadRequest("El radio debe ser mayor que 0");

            var area = Math.PI * radio * radio;
            return Ok(new { area });
        }

        [HttpGet("volumen/cubo")]
        public IActionResult CalcularVolumenCubo(double lado)
        {
            if (lado <= 0)
                return BadRequest("El lado debe ser mayor que 0");

            var volumen = lado * lado * lado;
            return Ok(new { volumen });
        }

        [HttpGet("volumen/esfera")]
        public IActionResult CalcularVolumenEsfera(double radio)
        {
            if (radio <= 0)
                return BadRequest("El radio debe ser mayor que 0");

            var volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
            return Ok(new { volumen });
        }

        [HttpGet("volumen/cilindro")]
        public IActionResult CalcularVolumenCilindro(double radio, double altura)
        {
            if (radio <= 0 || altura <= 0)
                return BadRequest("El radio y la altura deben ser mayores que 0");

            var volumen = Math.PI * radio * radio * altura;
            return Ok(new { volumen });
        }
    }
} 