namespace CorretoraABC.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Atualizar(T obj);
        void Excluir(T obj);
        IReadOnlyList<T> Listar();
    }
}
