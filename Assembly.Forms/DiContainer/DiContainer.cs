using Assembly.Forms.Contracts;
using Assembly.Forms.Repositories;
using Assembly.Forms.Services;

namespace Assembly.Forms.DiContainer
{
    public static class DiContainer
    {
        public static void AddRepos(this IServiceCollection services)
        {
            services.AddScoped<IIngredienteRepository, IngredienteRepository>();
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            services.AddScoped<IDatabase, Database>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IReceitaService, ReceitaService>();
        }
    }
}
