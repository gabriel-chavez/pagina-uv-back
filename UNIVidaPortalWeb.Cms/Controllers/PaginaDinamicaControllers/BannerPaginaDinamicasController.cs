﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.RecursosDTO;
using UNIVidaPortalWeb.Cms.Models.RecursoModel;
using UNIVidaPortalWeb.Cms.Services.PaginaDinamicaServices;

namespace UNIVidaPortalWeb.Cms.Controllers.PaginaDinamicaControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerPaginaDinamicasController : ControllerBase
    {
        private readonly IBannerPaginaDinamicaService _bannerPaginaDinamicaService;
        public IMapper _mapper { get; }

        public BannerPaginaDinamicasController(IBannerPaginaDinamicaService bannerPaginaDinamicaService, IMapper mapper)
        {
            _bannerPaginaDinamicaService = bannerPaginaDinamicaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BannerPagina>>> ObtenerBannersPaginaDinamica()
        {
            var bannerPaginaDinamicas = await _bannerPaginaDinamicaService.GetAllAsync();
            return Ok(bannerPaginaDinamicas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BannerPagina>> ObtenerBannerPaginaDinamica(int id)
        {
            var bannerPaginaDinamica = await _bannerPaginaDinamicaService.GetByIdAsync(id);
            if (bannerPaginaDinamica == null)
            {
                return NotFound();
            }
            return Ok(bannerPaginaDinamica);
        }

        [HttpPost]
        public async Task<ActionResult<BannerPagina>> CrearBannerPaginaDinamica(BannerPaginaDinamicaRequestDTO bannerPaginaDinamicaDto)
        {
            var bannerPaginaDinamica = _mapper.Map<BannerPagina>(bannerPaginaDinamicaDto);
            var bannerPaginaDinamicaCreado = await _bannerPaginaDinamicaService.AddAsync(bannerPaginaDinamica);
            return CreatedAtAction(nameof(ObtenerBannerPaginaDinamica), new { id = bannerPaginaDinamicaCreado.Id }, bannerPaginaDinamicaCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarBannerPaginaDinamica(int id, BannerPaginaDinamicaRequestDTO bannerPaginaDinamicaDto)
        {
            try
            {
                var bannerPaginaDinamica = _mapper.Map<BannerPagina>(bannerPaginaDinamicaDto);
                bannerPaginaDinamica.Id = id;
                await _bannerPaginaDinamicaService.UpdateAsync(bannerPaginaDinamica);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarBannerPaginaDinamica(int id)
        {
            try
            {
                await _bannerPaginaDinamicaService.DeleteByIdAsync(id);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
