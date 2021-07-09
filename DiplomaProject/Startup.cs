using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DiplomaProject.Models;
using DiplomaProject.Services.TimeEntryServiceNS;
using DiplomaProject.Services.EmployeeServiceNS;
using DiplomaProject.Services.ClientServiceNS;
using DiplomaProject.Services.ProjectServiceNS;
using DiplomaProject.Services.InvoiceServiceNS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DinkToPdf.Contracts;
using DinkToPdf;
using DiplomaProject.Services.PdfService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
using DiplomaProject.Services.AuthenticateServiceNS;
using DiplomaProject.Services.SecurityServiceNS;

namespace DiplomaProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });
            services.AddDbContext<DiplomaProjectDbContext>(opts => opts.UseNpgsql(Configuration["ConnectionString:postgreConnectionString"]));

            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddControllers();

            this.ConfigureDiplomaServices(services);

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Diploma Project - ASP.Net Core Web API",
                        Description = "The application for reporting and working time accounting system",
                        Version = "v1"
                    });

                var fileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var filePath = Path.Combine(AppContext.BaseDirectory, fileName);
                options.IncludeXmlComments(filePath);

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                       new OpenApiSecurityScheme
                       {
                          Reference = new OpenApiReference
                          {
                             Type = ReferenceType.SecurityScheme,
                             Id = "Bearer"
                          }
                       },
                       new string[] {}
                    }
                });
            });

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Diploma Project Web API");
                options.RoutePrefix = "";
            });
        }

        public void ConfigureDiplomaServices(IServiceCollection services)
        {
            services.AddScoped<ITimeEntryService, TimeEntryService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IInvoiceService, InvoiceDtos>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddScoped<ISecurityService, SecurityService>();
        }
    }
}
