using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.MenuDTO;
using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Services.MenuServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.MenuControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuPrincipalController : ControllerBase
    {
        private readonly IMenuPrincipalService _menuPrincipalService;
        public IMapper _mapper { get; }

        public MenuPrincipalController(IMenuPrincipalService menuPrincipalService, IMapper mapper)
        {
            _menuPrincipalService = menuPrincipalService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerMenus()
        {
            var menus = await _menuPrincipalService.GetAllAsync();
            //var menusOrdenados = await _menuPrincipalService.GetAsync(
            //    predicate: null,
            //    orderBy: b => b.OrderBy(x => x.Orden),
            //    includeString: null,
            //    disableTracking: true
            //);
            var resultado = new Resultado<IEnumerable<MenuPrincipal>>(menus, true, "Menús obtenidos correctamente");

            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerMenu(int id)
        {
            var menu = await _menuPrincipalService.GetByIdAsync(id);
            if (menu == null)
            {
                throw new NotFoundException("El menú con el ID especificado no fue encontrado.");
            }
            return Ok(new Resultado<MenuPrincipal>(menu, true, "Menú obtenido correctamente"));
        }

        [HttpPost]
        public async Task<ActionResult> CrearMenu(MenuPrincipalRequestDTO menuDto)
        {
            var menu = _mapper.Map<MenuPrincipal>(menuDto);
            var menuCreado = await _menuPrincipalService.AddAsync(menu);
            return CreatedAtAction(nameof(ObtenerMenu), new { id = menuCreado.Id }, new Resultado<MenuPrincipal>(menuCreado, true, "Menú creado exitosamente"));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarMenu(int id, MenuPrincipalRequestDTO menuDto)
        {
            try
            {
                var menu = _mapper.Map<MenuPrincipal>(menuDto);
                menu.Id = id;
                await _menuPrincipalService.UpdateAsync(menu);
                return Ok(new Resultado(true, "Menú actualizado exitosamente"));
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("El menú con el ID especificado no fue encontrado.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarMenu(int id)
        {
            try
            {
                await _menuPrincipalService.DeleteByIdAsync(id);
                return Ok(new Resultado(true, "Menú eliminado exitosamente"));
            }
            catch (NotFoundException)
            {
                throw new NotFoundException("El menú con el ID especificado no fue encontrado.");
            }
        }
    }
}
