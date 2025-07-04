﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Convocatorias.DTOs.PostulantesDTOs;
using UNIVidaPortalWeb.Convocatorias.Models.PostulantesModel;
using UNIVidaPortalWeb.Convocatorias.Services.PostulantesServices;
using UNIVidaPortalWeb.Convocatorias.Services.UsuariosServices;
using UNIVidaPortalWeb.Convocatorias.Utilidades;

namespace UNIVidaPortalWeb.Convocatorias.Controllers.PostulantesControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenciaLaboralController : ControllerBase
    {
        private readonly IReferenciaLaboralService _referenciaLaboralService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public ReferenciaLaboralController(IReferenciaLaboralService referenciaLaboralService, IMapper mapper, IUserService userService)
        {
            _referenciaLaboralService = referenciaLaboralService;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerReferenciasLaborales()
        {
            var referencias = await _referenciaLaboralService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<ReferenciaLaboral>>(referencias, true, "Referencias laborales obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerReferenciaLaboral(int id)
        {
            var referencia = await _referenciaLaboralService.GetByIdAsync(id);
            var resultado = new Resultado<ReferenciaLaboral>(referencia, true, "Referencia laboral obtenida correctamente");
            return Ok(resultado);
        }

        [HttpGet("ObtenerPorPostulante")]
        public async Task<ActionResult> ObtenerReferenciasPorPostulante()
        {
            var postulanteId = await _userService.PostulanteId();

            var referencias = await _referenciaLaboralService.GetAsync(r => r.PostulanteId == postulanteId);
            var resultado = new Resultado<IEnumerable<ReferenciaLaboral>>(referencias, true, "Referencias laborales del postulante obtenidas correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearReferenciaLaboral(ReferenciaLaboralRequestDTO referenciaDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var referencia = _mapper.Map<ReferenciaLaboral>(referenciaDto);
            referencia.PostulanteId = postulanteId;
            var referenciaCreada = await _referenciaLaboralService.AddAsync(referencia);
            var resultado = new Resultado<ReferenciaLaboral>(referenciaCreada, true, "Referencia laboral creada correctamente");
            return CreatedAtAction(nameof(ObtenerReferenciaLaboral), new { id = referenciaCreada.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarReferenciaLaboral(int id, ReferenciaLaboralRequestDTO referenciaDto)
        {
            var postulanteId = await _userService.PostulanteId();
            var referencia = _mapper.Map<ReferenciaLaboral>(referenciaDto);
            referencia.PostulanteId = postulanteId;
            referencia.Id = id;
            await _referenciaLaboralService.UpdateAsync(referencia);

            return Ok(new Resultado(true, "Referencia laboral actualizada correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarReferenciaLaboral(int id)
        {
            await _referenciaLaboralService.DeleteByIdAsync(id);
            return Ok(new Resultado(true, "Referencia laboral eliminada correctamente"));
        }
    }

}
