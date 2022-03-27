using CorretoraABC.Domain.Core.Entidades;

namespace CorretoraABC.Domain.Core.Interfaces.Services
{
    public interface ICalculadoraIndicadoresFinanceiros
    {
        IEnumerable<ValorEma> CalculeEma(IEnumerable<Cotacao> cotacoesx, int dias);
        IEnumerable<ValorMacd> CalculeMacd(IEnumerable<Cotacao> cotacoes);
    }
}