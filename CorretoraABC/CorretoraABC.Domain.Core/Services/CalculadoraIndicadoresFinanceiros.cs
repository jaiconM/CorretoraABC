using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Services;

namespace CorretoraABC.Domain.Core.Services
{
    public class CalculadoraIndicadoresFinanceiros : ICalculadoraIndicadoresFinanceiros
    {

        public IEnumerable<ValorMacd> CalculeMacd(IEnumerable<Cotacao> cotacoes)
        {
            var valoresMacd = new List<ValorMacd>();
            var fechamentos = cotacoes.Select(c => c.Fechamento).ToArray();

            var macds = new decimal[fechamentos.Length];
            var macdSignals = new decimal[fechamentos.Length];
            var macdHistories = new decimal[fechamentos.Length];
            int begIdx = -1;
            int nbElement = -1;

            var retCode = TALib.Core.Macd(fechamentos, 0, fechamentos.Length - 1, macds, macdSignals, macdHistories, out begIdx, out nbElement);

            for (int i = 0; i < macds.Length; i++)
            {
                var valorMacd = new ValorMacd
                {
                    Data = cotacoes.ElementAt(i).Data,
                    Valor = macds[i],
                    ValorSignal = macdSignals[i],
                    ValorHistorico = macdHistories[i]
                };
                valoresMacd.Add(valorMacd);
            }

            return valoresMacd;
        }

        public IEnumerable<ValorEma> CalculeEma(IEnumerable<Cotacao> cotacoes, int dias)
        {
            var valoresEma = new List<ValorEma>();
            var fechamentos = cotacoes.Select(c => c.Fechamento).ToArray();
            var emas = new decimal[fechamentos.Length - (dias - 1)];
            int begIdx = -1;
            int nbElement = -1;

            var retCode = TALib.Core.Ema(fechamentos, 0, fechamentos.Length - 1, emas, out begIdx, out nbElement, optInTimePeriod: dias);

            for (int i = 0; i < emas.Length; i++)
            {
                var valorEma = new ValorEma
                {
                    Data = cotacoes.ElementAt(begIdx++).Data,
                    Valor = emas[i]
                };
                valoresEma.Add(valorEma);
            }
            return valoresEma;
        }
    }
}
