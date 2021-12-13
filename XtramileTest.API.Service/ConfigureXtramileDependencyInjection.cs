using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace XtramileTest.API.Service
{
    public static class ConfigureDependencyInjection
    {
        public static IServiceCollection ConfigureXtramileDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IWeatherService, WeatherService>();
            return services;
        }
    }
}
