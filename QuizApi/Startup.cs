using MySqlConnector;
using QuizApi.Application;
using QuizApi.Repository;
using System.Data;

namespace QuizApi 

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigurationService(IServiceCollection services)
        {
            //services.AddDbContext<DataContext>(
            //    context => context.UseSqlite(Configuration.GetConnectionString("SqliteDataBase")));

            services.AddTransient<IDbConnection>(b => new MySqlConnection(Configuration.GetConnectionString("MySqlConnection")));
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );
            services.AddScoped<QuizApplication>(); // Registrar o serviço QuizApplication
            services.AddScoped<QuizRepository>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddCors();

        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(option => option.AllowAnyHeader()
                               .AllowAnyMethod()
                               .AllowAnyOrigin());

            app.MapControllers();
        }
    }
}

  


