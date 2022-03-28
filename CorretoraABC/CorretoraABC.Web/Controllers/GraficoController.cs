using CorretoraABC.App.Interfaces;
using CorretoraABC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace CorretoraABC.Web.Controllers
{
    public class GraficoController : Controller
    {
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly IAcaoApp _acaoApp;
        private readonly IDadosFinanceirosService _dadosFinanceirosService;

        public GraficoController(IAcaoApp acaoApp, IDadosFinanceirosService dadosFinanceirosService, IWebHostEnvironment appEnvironment)
        {
            _acaoApp = acaoApp;
            _dadosFinanceirosService = dadosFinanceirosService;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var acao = _acaoApp.ListarTodos()?.FirstOrDefault();
            var cotacoes = acao?.Cotacoes.OrderBy(cotacao => cotacao.Data).ToList();
            var viewModel = CrieViewModel(cotacoes);

            return View(viewModel);
        }

        private GraficoViewModel CrieViewModel(List<Domain.Core.Entidades.Cotacao>? cotacoes)
        {
            string nomeArquivo = "dados.json";
            var viewModel = new GraficoViewModel
            {
                JsonData = _dadosFinanceirosService.MonteDadosDeEMAeMACDParaGrafico(cotacoes),
                FilePath = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/Files/{nomeArquivo}"
            };

            CrieArquivo(viewModel.JsonData, nomeArquivo);

            return viewModel;
        }

        private void CrieArquivo(string dados, string nomeArquivo)
        {
            string pasta = "Files";
            string caminho_WebRoot = _appEnvironment.WebRootPath;
            string caminhoPastaFile = caminho_WebRoot + "\\" + pasta;

            if (!Directory.Exists(caminhoPastaFile))
            {
                Directory.CreateDirectory(caminhoPastaFile);
            }

            var filePath = Path.Combine(caminhoPastaFile, nomeArquivo);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            using FileStream fs = System.IO.File.Create(filePath);
            byte[] bytes = new UTF8Encoding(true).GetBytes(dados);
            fs.Write(bytes, 0, bytes.Length);
        }
    }
}
