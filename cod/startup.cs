public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<SmartCityContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

    services.AddControllers();
    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartCityProject", Version = "v1" });
    });
}