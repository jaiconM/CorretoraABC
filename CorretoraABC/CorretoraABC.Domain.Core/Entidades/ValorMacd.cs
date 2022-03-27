namespace CorretoraABC.Domain.Core.Entidades
{
    public class ValorMacd
    {
        public DateTime Data { get; internal set; }
        public decimal Valor { get; internal set; }
        public decimal ValorSignal { get; internal set; }
        public decimal ValorHistorico { get; internal set; }
    }
}
