using JobScrapper.Application.UseCases.JobScrapping;
using Microsoft.Extensions.DependencyInjection;
namespace JobScrapper.Application.Extensions;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        return services.AddScoped<IJobScrapping, JobScrapping>();
    }
}
