using FinanceiroAPI._2._0.Services.CargoServices;
using FinanceiroAPI._2._0.Services.UsuarioServices;
using FinanceiroAPI._2._0.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinanceiroAPI._2._0.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private IConfiguration _config;
        private readonly IUsuarioServices _usuarioServices;

        public UserController(IConfiguration config, IUsuarioServices usuarioServices)
        {
            _config = config;
            _usuarioServices = usuarioServices;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginViewModel model)
        {
            if (model == null)
            {
                return BadRequest("Request do cliente inválido");
            }

            var user = _usuarioServices.GetUser(model);

            if (user != null)
            {
                var _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var _issuer = _config["Jwt:Issuer"];
                var _audience = _config["Jwt:Audience"];
                var signinCredentials = new SigningCredentials(_secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: _issuer,
                    audience: _audience,
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(2),
                    signingCredentials: signinCredentials);
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
