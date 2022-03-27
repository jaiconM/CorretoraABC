using CorretoraABC.Domain.Core.Entidades;

namespace CorretoraABC.App.App
{
    public class DadosEMAeMACDparaGrafico
    {
        public IEnumerable<Cotacao> Cotacoes { get; set; }
        public IEnumerable<ValorEma> ValoresEma9 { get; set; }
        public IEnumerable<ValorEma> ValoresEma12 { get; set; }
        public IEnumerable<ValorEma> ValoresEma26 { get; set; }
        public IEnumerable<ValorMacd> ValoresMacd { get; set; }
        public int MenorQuantidade
        {
            get
            {
                var menorIndice = Cotacoes.Count();
                if (ValoresEma9.Count() < menorIndice)
                {
                    menorIndice = ValoresEma9.Count();
                }
                if (ValoresEma12.Count() < menorIndice)
                {
                    menorIndice = ValoresEma12.Count();
                }
                if (ValoresEma26.Count() < menorIndice)
                {
                    menorIndice = ValoresEma26.Count();
                }
                if (ValoresMacd.Count() < menorIndice)
                {
                    menorIndice = ValoresMacd.Count();
                }

                return menorIndice;
            }
        }
        public DadosEMAeMACDparaGrafico(IEnumerable<Cotacao> cotacoes,
                                        IEnumerable<ValorEma> valoresEma9,
                                        IEnumerable<ValorEma> valoresEma12,
                                        IEnumerable<ValorEma> valoresEma26,
                                        IEnumerable<ValorMacd> valoresMacd)
        {
            Cotacoes = cotacoes;
            ValoresEma9 = valoresEma9;
            ValoresEma12 = valoresEma12;
            ValoresEma26 = valoresEma26;
            ValoresMacd = valoresMacd;
        }
    }
}
