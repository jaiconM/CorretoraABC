using CorretoraABC.App.App;
using CorretoraABC.App.Interfaces;
using CorretoraABC.Data.Repository;
using CorretoraABC.Domain.Core.Interfaces.Repositories;
using CorretoraABC.Domain.Core.Interfaces.Services;
using CorretoraABC.Domain.Core.Services;

namespace CorretoraABC.Web.Config
{
    public static class IoC
    {
        public static void Configurar(this IServiceCollection services)
        {
            services.AddSingleton<IAcaoApp, AcaoApp>();
            services.AddSingleton<ICotacaoApp, CotacaoApp>();
            services.AddSingleton<IAcaoService, AcaoService>();
            services.AddSingleton<ICotacaoService, CotacaoService>();
            services.AddSingleton<IAcaoRepository, AcaoRepository>();
            services.AddSingleton<ICotacaoRepository, CotacaoRepository>();
            services.AddSingleton<ICalculadoraIndicadoresFinanceiros, CalculadoraIndicadoresFinanceiros>();
            services.AddSingleton<IDadosFinanceirosService, DadosFinanceirosService>();
        }
    }
}
