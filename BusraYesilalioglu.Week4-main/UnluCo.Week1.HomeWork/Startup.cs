using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Reflection;
using System.Text;
using UnluCo.Week1.HomeWork.DBOperations;
using UnluCo.Week1.HomeWork.Filter;
using UnluCo.Week1.HomeWork.Middlewares;
using UnluCo.Week1.HomeWork.MyIdentity;
using UnluCo.Week1.HomeWork.Services;

namespace UnluCo.Week1.HomeWork
{

    public class Startup
    {
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyIdentityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddIdentity<MyIdentityUser, MyIdentityRole>()
                .AddEntityFrameworkStores<MyIdentityContext>()
                .AddDefaultTokenProviders();



            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
               .AddJwtBearer(options => options.TokenValidationParameters =
                new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidateIssuer = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
                    ClockSkew = TimeSpan.Zero

                });



            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin",
                authBuilder => { authBuilder.RequireRole(RoleNames.Admin); });
                options.AddPolicy("Member",
                authBuilder => { authBuilder.RequireRole(RoleNames.Member); });
                options.AddPolicy("Guest",
                authBuilder => { authBuilder.RequireRole(RoleNames.Guest); });
            });
            
            services.AddMvc();
            services.AddControllers(config =>
            {
                config.Filters.Add(new ResultFilter());

            }); 
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "UnluCo.Week1.HomeWork", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
            });

            services.AddDbContext<CatStoreDbContext>(options => options.UseInMemoryDatabase(databaseName: "CatStoreDb"));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddSingleton<ILoggerService, ConsoleLogger>();
            services.AddScoped<TokenGenerator>();
            /*Singleton: Uygulamanýn çalýþmaya baþladýðý andan duruncaya kadar geçen süre
             *boyunca bir kez oluþturulur ve her zaman ayný nesne kullanýlýr.*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "UnluCo.Week1.HomeWork v1"));
            }
           

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCustomExceptionMiddleware();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }
        
    }
}
