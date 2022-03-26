using CorretoraABC.App.Interfaces;
using CorretoraABC.Domain.Core.Entidades;
using CorretoraABC.Domain.Core.Interfaces.Services;

namespace CorretoraABC.App.App
{
    public class CotacaoApp : ICotacaoApp
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoApp(ICotacaoService acaoService)
        {
            _cotacaoService = acaoService;
        }

        public void Adicionar(Cotacao obj)
        {
            _cotacaoService.Adicionar(obj);
        }

        public void Atualizar(Cotacao obj)
        {
            _cotacaoService.Atualizar(obj);
        }

        public void Excluir(Cotacao obj)
        {
            _cotacaoService.Excluir(obj);
        }

        public IReadOnlyList<Cotacao> ListarTodos()
        {
            return _cotacaoService.ListarTodos();
        }

        public Cotacao RecuperarPorId(Guid id)
        {
            return _cotacaoService.RecuperarPorId(id);
        }
    }
}
