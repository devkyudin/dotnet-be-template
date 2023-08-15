using TemplateApp.DomainServices;
using TemplateApp.ExternalServices;
using TemplateApp.Infrastructure;

namespace TemplateApp.Presentation;

public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public IConfiguration Configuration { get; }

	public void ConfigureServices(IServiceCollection serviceCollection)
	{
		serviceCollection.AddDomainServices(Configuration).AddInfrastructure(Configuration)
			.AddExternalServices(Configuration);
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
	{
	}
}