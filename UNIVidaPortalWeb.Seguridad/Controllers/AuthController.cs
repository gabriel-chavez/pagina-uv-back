using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using UNIVidaPortalWeb.Common.Token.Src;
using UNIVidaPortalWeb.Seguridad.Models;
using UNIVidaPortalWeb.Seguridad.Services;

namespace UNIVidaPortalWeb.Seguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccessService _accessService;
        private readonly JwtOptions _jwtOption;

        public AuthController(IAccessService accessService,
            IOptionsSnapshot<JwtOptions> jwtOption)
        {
            _accessService = accessService;
            _jwtOption = jwtOption.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_accessService.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AuthRequest request)
        {
            if (!_accessService.Validate(request.UserName, request.Password))
            {
                return Unauthorized();
            }

            Response.Headers.Add("access-control-expose-headers", "Authorization");
            Response.Headers.Add("Authorization", JwtToken.Create(_jwtOption));

            return Ok();
            //return Ok(new { token =  JwtToken.Create(_jwtOption) });
        }

    }
}
