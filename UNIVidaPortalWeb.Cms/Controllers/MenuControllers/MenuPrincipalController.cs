using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.MenuDTO;
using UNIVidaPortalWeb.Cms.Models.MenuModel;
using UNIVidaPortalWeb.Cms.Services.MenuServices;

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
        public async Task<ActionResult<IEnumerable<MenuPrincipal>>> ObtenerMenus()
        {
            var menus = await _menuPrincipalService.GetAllAsync();
            var seguro = await _menuPrincipalService.GetAsync(  
                predicate:null,
                orderBy:b => b.OrderBy(x => x.Orden),
                includeString: null,
                disableTracking:true
                );
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MenuPrincipal>> ObtenerMenu(int id)
        {
            var menu = await _menuPrincipalService.GetByIdAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }

        [HttpPost]
        public async Task<ActionResult<MenuPrincipal>> CrearMenu(MenuPrincipalRequestDTO menuDto)
        {
            var menu = _mapper.Map<MenuPrincipal>(menuDto);
            var menuCreado = await _menuPrincipalService.AddAsync(menu);
            return CreatedAtAction(nameof(ObtenerMenu), new { id = menuCreado.Id }, menuCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarMenu(int id, MenuPrincipalRequestDTO menuDto)
        {
            try
            {
                var menu = _mapper.Map<MenuPrincipal>(menuDto);
                menu.Id = id;
                await _menuPrincipalService.UpdateAsync(menu);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarMenu(int id)
        {
            try
            {
                await _menuPrincipalService.DeleteByIdAsync(id);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
