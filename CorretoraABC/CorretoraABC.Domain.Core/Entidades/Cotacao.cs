namespace CorretoraABC.Domain.Core.Entidades
{
    public class Cotacao
    {
        public Guid AcaoID { get; set; }
        public Guid CotacaoID { get; set; }
        public DateTime Data { get; set; }
        public decimal Abertura { get; set; }
        public decimal Alta { get; set; }
        public decimal Baixa { get; set; }
        public decimal Fechamento { get; set; }
        public decimal FechamentoAjustado { get; set; }
        public int Volume { get; set; }
    }
}