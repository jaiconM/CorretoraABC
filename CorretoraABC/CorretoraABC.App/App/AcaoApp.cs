using CorretoraABC.App.Interfaces;
using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Services;

namespace CorretoraABC.App.App
{
    public class AcaoApp : IAcaoApp
    {
        private readonly IAcaoService _acaoService;

        public AcaoApp(IAcaoService acaoService)
        {
            _acaoService = acaoService;
        }

        public void Adicionar(Acao obj)
        {
            _acaoService.Adicionar(obj);
        }

        public void Atualizar(Acao obj)
        {
            _acaoService.Atualizar(obj);
        }

        public void Excluir(Acao obj)
        {
            _acaoService.Excluir(obj);
        }

        public IReadOnlyList<Acao> ListarTodos()
        {
            return _acaoService.ListarTodos();
        }

        public Acao RecuperarPorId(Guid id)
        {
            return _acaoService.RecuperarPorId(id);
        }
    }
}
