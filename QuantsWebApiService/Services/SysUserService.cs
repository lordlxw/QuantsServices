using QuantsRepository.Interfaces;
using QuantsRepository.Models;

namespace QuantsWebApiService.Services
{
    public class SysUserService
    {
        private readonly IRepository<SysUser> _sysUserRepository;

        public SysUserService(IRepository<SysUser> sysUserRepository)
        {
            _sysUserRepository = sysUserRepository;
        }

        public async Task<IEnumerable<SysUser>> GetAllSysUsersAsync()
        {
            return await _sysUserRepository.GetAllAsync();
        }
    }

}
