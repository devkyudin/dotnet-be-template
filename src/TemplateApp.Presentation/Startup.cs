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
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
	{
	}
}