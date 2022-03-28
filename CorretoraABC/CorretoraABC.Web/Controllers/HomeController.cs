using CorretoraABC.App.App;
using CorretoraABC.App.Interfaces;
using CorretoraABC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CorretoraABC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAcaoApp _acaoApp;
        private readonly IDadosFinanceirosService _dadosFinanceirosService;

        public HomeController(IAcaoApp acaoApp, IDadosFinanceirosService dadosFinanceirosService)
        {
            _acaoApp = acaoApp;
            _dadosFinanceirosService = dadosFinanceirosService;
        }

        public IActionResult Index()
        {
            var viewModel = MonteViewModel();
            return View(viewModel);
        }

        private IEnumerable<HomeViewModel> MonteViewModel()
        {
            var acao = _acaoApp.ListarTodos()?.FirstOrDefault();
            var cotacoes = acao?.Cotacoes.OrderBy(cotacao => cotacao.Data).ToList();
            var dadosParaOGrafico = _dadosFinanceirosService.MonteDadosDeEMAeMACDParaListagem(cotacoes);
            return MapeieParaViewModel(dadosParaOGrafico);
        }

        private IEnumerable<HomeViewModel> MapeieParaViewModel(DadosEMAeMACDparaGrafico dadosParaOGrafico)
        {
            var viewModels = new List<HomeViewModel>();
            for (int i = 0; i < dadosParaOGrafico.MenorQuantidade; i++)
            {
                viewModels.Add(
                    new HomeViewModel
                    {
                        Data = dadosParaOGrafico.Cotacoes.ElementAt(i).Data,
                        FechamentoDoDia = dadosParaOGrafico.Cotacoes.ElementAt(i).Fechamento,
                        Ema9 = dadosParaOGrafico.ValoresEma9.ElementAt(i).Valor,
                        Ema12 = dadosParaOGrafico.ValoresEma12.ElementAt(i).Valor,
                        Ema26 = dadosParaOGrafico.ValoresEma26.ElementAt(i).Valor,
                        Macd = dadosParaOGrafico.ValoresMacd.ElementAt(i).Valor,
                        MacdSignal = dadosParaOGrafico.ValoresMacd.ElementAt(i).ValorSignal,
                        MacdHistograma = dadosParaOGrafico.ValoresMacd.ElementAt(i).ValorHistorico
                    }
                );
            }
            return viewModels;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}