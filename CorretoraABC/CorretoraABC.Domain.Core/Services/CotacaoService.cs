using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Repositories;
using CorretoraABC.Domain.Core.Interfaces.Services;

namespace CorretoraABC.Domain.Core.Services
{
    public class CotacaoService : ICotacaoService
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoService(ICotacaoRepository cotacaoRepository)
        {
            _cotacaoRepository = cotacaoRepository;
        }

        public void Adicionar(Cotacao obj)
        {
            _cotacaoRepository.Adicionar(obj);
        }

        public void Atualizar(Cotacao obj)
        {
            _cotacaoRepository.Atualizar(obj);
        }

        public void Excluir(Cotacao obj)
        {
            _cotacaoRepository.Excluir(obj);
        }

        public IReadOnlyList<Cotacao> ListarTodos()
        {
            return _cotacaoRepository.Listar();
        }

        public Cotacao RecuperarPorId(Guid id)
        {
            return _cotacaoRepository.RecuperarPorId(id);
        }
    }
}
