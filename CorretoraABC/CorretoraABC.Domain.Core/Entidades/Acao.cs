using System.ComponentModel.DataAnnotations;

namespace CorretoraABC.Domain.Core.Entidades
{
    public class Acao
    {
        public Guid AcaoID { get; set; }
        [MaxLength(300)]
        public string Nome { get; set; }
        [MaxLength(10)]
        public string Sigla { get; set; }

        public IEnumerable<Cotacao> Cotacoes { get; set; }
    }
}
