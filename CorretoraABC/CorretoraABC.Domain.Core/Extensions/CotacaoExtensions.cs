using CorretoraABC.Domain.Core.Entidades;
using Skender.Stock.Indicators;

namespace CorretoraABC.Domain.Core.Extensions
{
    public static class CotacaoExtensions
    {
        public static IEnumerable<Quote> ToQuotes(this IEnumerable<Cotacao> cotacoes)
        {
            return cotacoes.Select(c => new Quote { Date = c.Data, Open = c.Abertura, Close = c.Fechamento, Low = c.Baixa, High = c.Alta, Volume = c.Volume });
        }
    }
}
