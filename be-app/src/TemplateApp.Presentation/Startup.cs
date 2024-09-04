using TemplateApp.DomainServices;
using TemplateApp.ExternalServices;
using TemplateApp.Infrastructure;

namespace TemplateApp.Presentation;

public class Startup(IConfiguration configuration)
{
	public IConfiguration Configuration { get; } = configuration;

	public void ConfigureServices(IServiceCollection serviceCollection)
	{
		serviceCollection.AddDomainServices(Configuration).AddInfrastructure(Configuration)
			.AddExternalServices(Configuration);
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
	{
	}
}