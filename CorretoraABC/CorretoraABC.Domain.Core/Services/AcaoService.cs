using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Repositories;
using CorretoraABC.Domain.Core.Interfaces.Services;

namespace CorretoraABC.Domain.Core.Services
{
    public class AcaoService : IAcaoService
    {
        private readonly IAcaoRepository _acaoRepository;

        public AcaoService(IAcaoRepository acaoRepository)
        {
            _acaoRepository = acaoRepository;
        }

        public void Adicionar(Acao obj)
        {
            _acaoRepository.Adicionar(obj);
        }

        public void Atualizar(Acao obj)
        {
            _acaoRepository.Atualizar(obj);
        }

        public void Excluir(Acao obj)
        {
            _acaoRepository.Excluir(obj);
        }

        public IReadOnlyList<Acao> ListarTodos()
        {
            return _acaoRepository.Listar();
        }

        public Acao RecuperarPorId(Guid id)
        {
            return _acaoRepository.RecuperarPorId(id);
        }
    }
}
