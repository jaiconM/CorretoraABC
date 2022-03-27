using CorretoraABC.Data.Config;
using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CorretoraABC.Data.Repository
{
    public class AcaoRepository : BaseRepository<Acao>, IAcaoRepository
    {
        public override IReadOnlyList<Acao> Listar()
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            return db.Acoes
                     .Include(a => a.Cotacoes)
                     .AsNoTracking()
                     .ToList();
        }

        public override Acao RecuperarPorId(Guid id)
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            return db.Acoes
                     .Include(a => a.Cotacoes)
                     .FirstOrDefault(a => a.AcaoID == id);
        }
    }
}
