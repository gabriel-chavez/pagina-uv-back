using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UNIVidaPortalWeb.Cms.DTOs.SegurosDTO;
using UNIVidaPortalWeb.Cms.Models.SeguroModel;
using UNIVidaPortalWeb.Cms.Services.SeguroServices;

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
        public async Task<ActionResult<IEnumerable<Plan>>> ObtenerPlanes()
        {
            var planes = await _planService.GetAllAsync();
            return Ok(planes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Plan>> ObtenerPlan(int id)
        {
            var plan = await _planService.GetByIdAsync(id);
            return Ok(plan);
        }

        [HttpPost]
        public async Task<ActionResult<Plan>> CrearPlan(PlanRequestDTO planDto)
        {
            var plan = _mapper.Map<Plan>(planDto);
            var planCreado = await _planService.AddAsync(plan);
            return CreatedAtAction(nameof(ObtenerPlan), new { id = planCreado.Id }, planCreado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarPlan(int id, PlanRequestDTO planDto)
        {
            var plan = _mapper.Map<Plan>(planDto);
            plan.Id = id;
            await _planService.UpdateAsync(plan);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPlan(int id)
        {
            await _planService.DeleteByIdAsync(id);
            return NoContent();
        }
    }
}
