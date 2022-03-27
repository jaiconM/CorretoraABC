using CorretoraABC.App.App;
using CorretoraABC.Domain.Core.Entidades;

namespace CorretoraABC.App.Interfaces
{
    public interface IDadosFinanceirosService
    {
        DadosEMAeMACDparaGrafico MonteDadosDeEMAeMACDParaListagem(List<Cotacao> cotacoes);
        string MonteDadosDeEMAeMACDParaGrafico(List<Cotacao> cotacoes);
    }
}