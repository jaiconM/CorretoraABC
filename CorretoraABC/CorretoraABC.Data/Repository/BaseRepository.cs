using CorretoraABC.Data.Config;
using CorretoraABC.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CorretoraABC.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>, IDisposable where T : class
    {
        protected readonly DbContextOptions<CorretoraABCDbContext> _optionsBuilder;

        public BaseRepository()
        {
            _optionsBuilder = new DbContextOptions<CorretoraABCDbContext>();
        }

        public virtual void Adicionar(T obj)
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }

        public virtual void Atualizar(T obj)
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            db.Set<T>().Update(obj);
            db.SaveChanges();
        }

        public virtual void Excluir(T obj)
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }

        public virtual IReadOnlyList<T> Listar()
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            return db.Set<T>().AsNoTracking().ToList();
        }

        public virtual T RecuperarPorId(Guid id)
        {
            using var db = new CorretoraABCDbContext(_optionsBuilder);
            return db.Set<T>().Find(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
