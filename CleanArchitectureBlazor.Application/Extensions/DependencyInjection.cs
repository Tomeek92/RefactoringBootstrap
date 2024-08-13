using CleanArchitectureBlazor.Application.Interfaces;
using CleanArchitectureBlazor.Application.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureBlazor.Application.Service
{
    public static class DependencyInjection
    {
        public static void  AddApplication(this IServiceCollection services)
        {
            services.AddScoped<INewsLetterEmailService, NewsLetterEmailService>();
            services.AddScoped<IPriceService, PriceService>();
            services.AddScoped<IPriceTrainService, PriceTrainService>();   
            services.AddAutoMapper(typeof(MappingProfile)); 
        }
    }
}
