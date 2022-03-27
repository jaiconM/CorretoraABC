namespace CorretoraABC.App.Interfaces
{
    public interface IBaseApp<T> where T : class
    {
        public void Adicionar(T obj);

        public void Atualizar(T obj);

        public void Excluir(T obj);

        public IReadOnlyList<T> ListarTodos();

        public T RecuperarPorId(Guid id);
    }
}
