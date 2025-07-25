﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormacionAcademicaController : ControllerBase
    {
        private readonly IFormacionAcademicaService _formacionAcademicaService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public FormacionAcademicaController(IFormacionAcademicaService formacionAcademicaService, IMapper mapper, IUserService userService)
        {
            _formacionAcademicaService = formacionAcademicaService;
            _mapper = mapper;
            _userService = userService;
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

        [HttpGet("ObtenerPorPostulante")]
        public async Task<ActionResult> ObtenerFormacionesPorPostulante()
        {
            var incluir = new List<Expression<Func<FormacionAcademica, object>>>
            {
                c => c.ParNivelFormacion,                
            };
            var postulanteId = await _userService.PostulanteId();

            var formaciones = await _formacionAcademicaService.GetAsync(f => f.PostulanteId == postulanteId, includes: incluir);
            var resultado = new Resultado<IEnumerable<FormacionAcademica>>(formaciones, true, "Formaciones académicas del postulante obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearFormacionAcademica(FormacionAcademicaRequestDTO formacionDto)
        {
            var postulanteId = await _userService.PostulanteId();

            var formacion = _mapper.Map<FormacionAcademica>(formacionDto);
            formacion.PostulanteId=postulanteId;
            var formacionCreada = await _formacionAcademicaService.AddAsync(formacion);
            var resultado = new Resultado<FormacionAcademica>(formacionCreada, true, "Formación académica creada correctamente");
            return CreatedAtAction(nameof(ObtenerFormacionAcademica), new { id = formacionCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarFormacionAcademica(int id, FormacionAcademicaRequestDTO formacionDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var formacion = _mapper.Map<FormacionAcademica>(formacionDto);
            formacion.PostulanteId = postulanteId;
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
