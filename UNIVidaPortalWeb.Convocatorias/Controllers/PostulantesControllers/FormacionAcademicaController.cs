using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormacionAcademicaController : ControllerBase
    {
        private readonly IFormacionAcademicaService _formacionAcademicaService;
        private readonly IMapper _mapper;

        public FormacionAcademicaController(IFormacionAcademicaService formacionAcademicaService, IMapper mapper)
        {
            _formacionAcademicaService = formacionAcademicaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerFormacionesAcademicas()
        {
            var incluir = new List<Expression<Func<FormacionAcademica, object>>>
            {
                c => c.ParNivelFormacion,
            };
            var formaciones = await _formacionAcademicaService.GetAllAsync(incluir);
            var resultado = new Resultado<IEnumerable<FormacionAcademica>>(formaciones, true, "Formaciones académicas obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerFormacionAcademica(int id)
        {
            var incluir = new List<Expression<Func<FormacionAcademica, object>>>
            {
                c => c.ParNivelFormacion,
            };
            var formacion = await _formacionAcademicaService.GetByIdAsync(id, incluir);
            var resultado = new Resultado<FormacionAcademica>(formacion, true, "Formación académica obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante/{id}")]
        public async Task<ActionResult> ObtenerFormacionesPorPostulante(int id)
        {
            var incluir = new List<Expression<Func<FormacionAcademica, object>>>
            {
                c => c.ParNivelFormacion,                
            };
            var formaciones = await _formacionAcademicaService.GetAsync(f => f.PostulanteId == id);
            var resultado = new Resultado<IEnumerable<FormacionAcademica>>(formaciones, true, "Formaciones académicas del postulante obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearFormacionAcademica(FormacionAcademicaRequestDTO formacionDto)
        {
            var formacion = _mapper.Map<FormacionAcademica>(formacionDto);
            var formacionCreada = await _formacionAcademicaService.AddAsync(formacion);
            var resultado = new Resultado<FormacionAcademica>(formacionCreada, true, "Formación académica creada correctamente");
            return CreatedAtAction(nameof(ObtenerFormacionAcademica), new { id = formacionCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarFormacionAcademica(int id, FormacionAcademicaRequestDTO formacionDto)
        {
            var formacion = _mapper.Map<FormacionAcademica>(formacionDto);
            formacion.Id = id;
            await _formacionAcademicaService.UpdateAsync(formacion);

            return Ok(new Resultado(true, "Formación académica actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarFormacionAcademica(int id)
        {
            await _formacionAcademicaService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Formación académica eliminada correctamente"));
        }
    }

}
