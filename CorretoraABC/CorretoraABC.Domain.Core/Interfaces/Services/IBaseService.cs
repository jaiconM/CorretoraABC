namespace CorretoraABC.Domain.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        IReadOnlyList<T> ListarTodos();
        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Atualizar(T obj);
        void Excluir(T obj);
    }
}
