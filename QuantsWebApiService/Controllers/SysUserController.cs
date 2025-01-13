using Microsoft.AspNetCore.Mvc;
using QuantsWebApiService.Services;

namespace QuantsWebApiService.Controllers
{
    //[Route("api/[controller]")]

    [ApiController]
    [Route("[controller]")]
    public class SysUserController : ControllerBase
    {
        private readonly SysUserService _sysUserService;

        public SysUserController(SysUserService sysUserService)
        {
            _sysUserService = sysUserService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSysUsers()
        {
            var users = await _sysUserService.GetAllSysUsersAsync();
            return Ok(users);
        }
    }

}
