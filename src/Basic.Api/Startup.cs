using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Basic.Api.Data;
using Basic.Api.Services;
using Basic.Api.Services.Impl;
using Core;
using Core.Consul;
using Core.EventBus.Impletment.RabbitMq;
using Core.Logger;
using Core.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Basic.Api
{
    public class Startup : CommonStartup
    {
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        public override void CommonServices(IServiceCollection services)
        {
            //services.AddDbContext<BasicContext>(options =>
            //{
            //    options.UseMySql(Configuration.GetSection("Zeus:Connection").Value, sql => sql.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name));
            //});

            services.AddCoreSeriLog()
                     .AddConsul()
                             .AddCoreSwagger();
        }

        public override void CommonConfigure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app
                .UseConsul()
                .UseCoreSwagger();
        }
    }
}
