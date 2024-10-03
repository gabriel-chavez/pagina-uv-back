using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;
using UNIVidaPortalWeb.Cms.Utilidades;

namespace UNIVidaPortalWeb.Cms.Controllers.Seguros
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        private readonly IPlanService _planService;
        private readonly IMapper _mapper;

        public PlanController(IPlanService planService, IMapper mapper)
        {
            _planService = planService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> ObtenerPlanes()
        {
            var planes = await _planService.GetAllAsync();
            var resultado = new Resultado<IEnumerable<Plan>>(planes, true, "Planes obtenidos correctamente");
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> ObtenerPlan(int id)
        {
            var plan = await _planService.GetByIdAsync(id);           
            var resultado = new Resultado<Plan>(plan, true, "Plan obtenido correctamente");
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<ActionResult> CrearPlan(PlanRequestDTO planDto)
        {
            var plan = _mapper.Map<Plan>(planDto);
            var planCreado = await _planService.AddAsync(plan);
            var resultado = new Resultado<Plan>(planCreado, true, "Plan creado correctamente");
            return CreatedAtAction(nameof(ObtenerPlan), new { id = planCreado.Id }, resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> ActualizarPlan(int id, PlanRequestDTO planDto)
        {
            try
            {
                var plan = _mapper.Map<Plan>(planDto);
                plan.Id = id;
                await _planService.UpdateAsync(plan);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException();
            }

            return Ok(new Resultado(true, "Plan actualizado correctamente"));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarPlan(int id)
        {
            try
            {
                await _planService.DeleteByIdAsync(id);
            }
            catch (NotFoundException ex)
            {
                throw new NotFoundException(ex.Message);
            }

            return Ok(new Resultado(true, "Plan eliminado correctamente"));
        }
    }
}
