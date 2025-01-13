using Microsoft.EntityFrameworkCore;
using QuantsRepository.Data;
using QuantsRepository.Implements;
using QuantsRepository.Interfaces;
using QuantsWebApiService.Services;

namespace QuantsWebApiService
{
    public class ProgramU
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // 注册 ApplicationDbContext

            var sqlStr = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // 使用你的连接字符串

            // 注册 IRepository 和 Repository
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // 注册 SysUserService
            builder.Services.AddScoped<SysUserService>();

            // 添加控制器服务
            builder.Services.AddControllers();
            var app = builder.Build();

            app.UseRouting();
            // Configure the HTTP request pipeline.

            //app.UseAuthorization();

            
            app.MapControllers();

            app.Run();
        }
    }
}
