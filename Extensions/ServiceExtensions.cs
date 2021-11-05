using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerServices;
using Contract;

namespace LoanAppApi.Extensions
{
    public static class  ServiceExtensions
    {
        public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
             {
                 options.AddPolicy("CorsPolicy", builder =>
                 builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader());
               
             });

        public static void ConfigureIISIntegration(this IServiceCollection services) => 
        services.Configure<IISOptions>(options =>
        {
        });

       
    }
}
