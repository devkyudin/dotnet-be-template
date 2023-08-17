using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TemplateApp.DomainServices;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddDomainServices(this IServiceCollection serviceCollection,
		IConfiguration configuration)
	{
		return serviceCollection;
	}
}