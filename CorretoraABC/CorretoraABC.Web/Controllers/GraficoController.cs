using CorretoraABC.App.Interfaces;
using CorretoraABC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CorretoraABC.Web.Controllers
{
    public class GraficoController : Controller
    {
        private readonly IAcaoApp _acaoApp;
        private readonly IDadosFinanceirosService _dadosFinanceirosService;

        public GraficoController(IAcaoApp acaoApp, IDadosFinanceirosService dadosFinanceirosService)
        {
            _acaoApp = acaoApp;
            _dadosFinanceirosService = dadosFinanceirosService;
        }

        public IActionResult Index()
        {
            var viewModel = new GraficoViewModel();
            var acao = _acaoApp.ListarTodos()?.FirstOrDefault();
            var cotacoes = acao?.Cotacoes.OrderBy(cotacao => cotacao.Data).ToList();
            viewModel.JsonData = _dadosFinanceirosService.MonteDadosDeEMAeMACDParaGrafico(cotacoes);

            return View(viewModel);
        }
    }
}
