using CorretoraABC.App.Interfaces;
using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Services;
using System.Text.Json;

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
            var dados = new List<List<double>>();
            for (int i = 0; i < cotacoes.Count; i++)
            {
                var dado = new List<double>();
                dado.Add(cotacoes.ElementAt(i).Data.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
                dado.Add((double)cotacoes.ElementAt(i).Abertura);
                dado.Add((double)cotacoes.ElementAt(i).Alta);
                dado.Add((double)cotacoes.ElementAt(i).Baixa);
                dado.Add((double)cotacoes.ElementAt(i).Fechamento);
                dados.Add(dado);
            }
            return JsonSerializer.Serialize(dados);
        }
    }
}
