using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Extensions;
using CorretoraABC.Domain.Core.Interfaces.Services;
using Skender.Stock.Indicators;

namespace CorretoraABC.Domain.Core.Services
{
    public class CalculadoraIndicadoresFinanceiros : ICalculadoraIndicadoresFinanceiros
    {
        public IEnumerable<ValorMacd> CalculeMacd(IEnumerable<Cotacao> cotacoes)
        {
            var quotes = cotacoes.ToQuotes();

            var result = quotes.GetMacd();

            var valoresMacd = result.Select(r => new ValorMacd
            {
                Data = r.Date,
                Valor = r.Macd.GetValueOrDefault(),
                ValorSignal = r.Signal.GetValueOrDefault(),
                ValorHistorico = r.Histogram.GetValueOrDefault()
            });

            return valoresMacd;
        }

        public IEnumerable<ValorEma> CalculeEma(IEnumerable<Cotacao> cotacoes, int dias)
        {
            var quotes = cotacoes.ToQuotes();

            var result = quotes.GetEma(dias);

            var valoresEma = result.Select(r => new ValorEma
            {
                Data = r.Date,
                Valor = r.Ema.GetValueOrDefault()
            });

            return valoresEma;
        }
    }
}
