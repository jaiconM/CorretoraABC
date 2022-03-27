using CorretoraABC.App.Interfaces;
using CorretoraABC.Domain.Core.Interfaces.Services;
using CorretoraABC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CorretoraABC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAcaoApp _acaoApp;
        private readonly ICalculadoraIndicadoresFinanceiros _calculadoraIndicadoresFinanceiros;

        public HomeController(IAcaoApp acaoApp, ICalculadoraIndicadoresFinanceiros calculadoraIndicadoresFinanceiros)
        {
            _acaoApp = acaoApp;
            _calculadoraIndicadoresFinanceiros = calculadoraIndicadoresFinanceiros;
        }

        public IActionResult Index()
        {
            var viewModel = MonteViewModel();
            return View(viewModel);
        }

        private HomeViewModel MonteViewModel()
        {
            var cotacoes = _acaoApp.ListarTodos()?.FirstOrDefault()?.Cotacoes.OrderBy(cotacao => cotacao.Data);
            var valoresEma9 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 9);
            var valoresEma12 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 12);
            var valoresEma26 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 26);
            var valoresMacd = _calculadoraIndicadoresFinanceiros.CalculeMacd(cotacoes);
            return new HomeViewModel(cotacoes, valoresEma9, valoresEma12, valoresEma26, valoresMacd);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}