using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace API_REST_Exemplo
{
    public class ImplementacaoDosMetodosEsperadosPeloNetCore
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<QualquerCoisa>();
    }
}
