using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Oreintada a Servicios
Nombre del Maestro: Joel Ivan Chuc Uc
Nombre de la actividad: API PALIMDROMOS
Nombre del alumno o Alumnos: Jesus Ivan Estrella Yah
Cuatrimestre: 4to Cuatrimestre
Grupo: 4B
Parcial: 1er Parcial
 */

namespace IMCEstrella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerIMC : ControllerBase
    {
        [HttpGet]

        public IActionResult IMCOperacion(double altura, double peso)
        {
            var persona = new Persona();
            persona.Peso = peso;
            persona.Altura = altura / 100;
            var AUltimate = persona.Altura;
            var IndiceMasaCorporal = peso / (AUltimate*AUltimate);
            var Rango = "";

            if (IndiceMasaCorporal < 18.5)
            {
                Rango = "Necesitas alimentarte. Te falta peso!!!";
            }
            else
            {
                if (IndiceMasaCorporal >= 18.5 && IndiceMasaCorporal <= 24.9)
                {
                    Rango = "Tienes un peso en lo rango de lo normal";
                }
                else
                {
                    if (IndiceMasaCorporal >= 25.0 && IndiceMasaCorporal <= 29.9)
                    {
                        Rango = "Estas pasado un poco de peso. Tienes que hacer un poco de ejercicio";
                    }
                    else
                    {
                        Rango = "Estas Obeso";
                    }
                }
            }
            var Resultado = "Su Indice de Masa Corporal es: " + Convert.ToString(IndiceMasaCorporal) + "y " + Rango;
            return Ok(Resultado);
        }
    }
}