using CorretoraABC.App.Interfaces;
using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Services;

namespace CorretoraABC.App.App
{
    public class DadosFinanceirosService : IDadosFinanceirosService
    {
        private readonly ICalculadoraIndicadoresFinanceiros _calculadoraIndicadoresFinanceiros;

        public DadosFinanceirosService(ICalculadoraIndicadoresFinanceiros calculadoraIndicadoresFinanceiros)
        {
            _calculadoraIndicadoresFinanceiros = calculadoraIndicadoresFinanceiros;
        }

        public DadosEMAeMACDparaGrafico MonteDadosDeEMAeMACDParaListagem(List<Cotacao> cotacoes)
        {
            var valoresEma9 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 9);
            var valoresEma12 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 12);
            var valoresEma26 = _calculadoraIndicadoresFinanceiros.CalculeEma(cotacoes, 26);
            var valoresMacd = _calculadoraIndicadoresFinanceiros.CalculeMacd(cotacoes);

            return new DadosEMAeMACDparaGrafico(cotacoes, valoresEma9, valoresEma12, valoresEma26, valoresMacd);
        }

        public string MonteDadosDeEMAeMACDParaGrafico(List<Cotacao> cotacoes)
        {
            var dados = "[";
            foreach (var cotacao in cotacoes)
            {
                var dado = $"[{cotacao.Data.Ticks},{Formate(cotacao.Abertura)},{Formate(cotacao.Alta)},{Formate(cotacao.Baixa)},{Formate(cotacao.Fechamento)}],";
                dados += dado;
            }
            return $"{dados.Substring(0, dados.Length - 1)}]";
        }

        private static string Formate(decimal valor)
        {
            return valor.ToString("#0.00").Replace(',', '.');
        }
    }
}
