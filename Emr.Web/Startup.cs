using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain;
using Emr.Domain.Accounts;
using Emr.Domain.BloodTypes;
using Emr.Domain.Diagnos;
using Emr.Domain.Drags;
using Emr.Domain.Epmrs;
using Emr.Domain.HealGroups;
using Emr.Domain.Medics;
using Emr.Domain.PatientRecords;
using Emr.Domain.Patients;
using Emr.Domain.Researchs;
using Emr.Domain.RhesusFactors;
using Emr.Domain.TypeOfDisability;
using Emr.Domain.Vaccinations;
using Emr.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shelter.Web.Extensions;
using Swashbuckle.AspNetCore.Swagger;

namespace Emr.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        private IConfiguration _config { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.Filters.Add<ExceptionFilter>());

            services.AddDbContext<DatabaseContext>(opt => opt.UseNpgsql(_config["DatabaseConnection"], npgOpt =>
                npgOpt.MigrationsAssembly("Emr.Web")));

            services.AddAutoMapper(x => { x.AddProfile<MapperProfile>(); });

            //TODO:Тут подключаются сервисы
            services.AddScoped<InitializerDb>();
            services.AddScoped<IAccountService,AccountService>();
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IDragService, DragService>();
            services.AddScoped<IHealthService, HealthService>();
            services.AddScoped<IBloodTypeService, BloodTypeService>();
            services.AddScoped<IRhesusFactorService, RhesusFactorService>();
            services.AddScoped<PatientRecordService>();
            services.AddScoped<MedicService>();
            services.AddScoped<ResearchService>();
            services.AddScoped<VaccinationService>();
            services.AddScoped<ITypeDisabilityService, TypeDisabilityService>();
            services.AddScoped<IDiagnosService, DiagnosService>();
            services.AddScoped<IEpmrService, EpmrService>();

            services.AddIdentity<Client, Role>()
                .AddRoleStore<RoleStore>()
                .AddUserStore<ClientStore>()
                .AddDefaultTokenProviders();
            //services.AddAuthentication()
            //    .AddApplicationCookie();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
                options.DescribeAllEnumsAsStrings();

                options.MapType<IFormFile>(() => new Schema { Type = "file" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            logger.AddConsole();
       
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "help";
            });

            app.UseAuthentication();

            app.UseMvcWithDefaultRoute();
        }
    }
}
