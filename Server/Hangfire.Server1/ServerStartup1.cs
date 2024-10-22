namespace Hangfire.Server1
{
    public class ServerStartup1
    {
        public ServerStartup1(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddHangfire(configuration => configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage("Server=localhost;Database=HangfireTest;User Id=sa;Password=Karamel@32;TrustServerCertificate=true"));

            services.AddHangfireServer(o => {
                o.ServerName = "Server1";
                o.Queues = new[] { "fire-and-forget-job", "repetitive-job", "scheduled-job" };
                o.WorkerCount = 1;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            //app.UseHangfireDashboard();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
