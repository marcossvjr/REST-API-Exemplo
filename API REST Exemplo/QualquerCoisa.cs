using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API_REST_Exemplo
{
    public class QualquerCoisa
    {
        public QualquerCoisa(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //ADICIONA LISTA DE JOGOS PADRÃO
            DBFake.Tbl_Jogo.Add(new Jogo("GTA V"));
            DBFake.Tbl_Jogo.Add(new Jogo("Escape From RJ"));
            DBFake.Tbl_Jogo.Add(new Jogo("PAC-MAN"));
            DBFake.Tbl_Jogo.Add(new Jogo("Mario!"));//Que Mário?
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
