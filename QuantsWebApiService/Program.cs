using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using QuantsRepository.Data;
using QuantsRepository.Implements;
using QuantsRepository.Interfaces;
using QuantsWebApiService.Services;
using System.Text;

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

            // 添加 JWT 配置
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                        ValidAudience = builder.Configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]))
                    };
                });

            // 添加 Swagger 生成器服务
            builder.Services.AddEndpointsApiExplorer();  // 必须添加此行来启用 Swagger
            builder.Services.AddSwaggerGen();  // 添加 Swagger 生成器
            // 注册 IRepository 和 Repository
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // 注册 SysUserService
            builder.Services.AddScoped<SysUserService>();
        
            // 添加控制器服务
            builder.Services.AddControllers();


    
            var app = builder.Build();
            // 启用 Swagger 和 Swagger UI（仅开发环境）
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();  // 启用 Swagger 生成
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");  // Swagger UI 的入口
                    c.RoutePrefix = string.Empty;
                });
            }
            app.UseRouting();
            // Configure the HTTP request pipeline.

            //app.UseAuthorization();

            
            app.MapControllers();

            app.Run();
        }
    }
}
