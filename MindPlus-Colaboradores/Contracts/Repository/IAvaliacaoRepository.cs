using MindPlus_Colaboradores.DTO;
using MindPlus_Colaboradores.Entity;

namespace MindPlus_Colaboradores.Contracts.Repository
{
    public interface IAvaliacaoRepository
    {
        Task RealizarAvaliacao(AvaliacaoDTO avaliacao);
        Task<IEnumerable<AvaliacaoEntity>> VisualizarAvaliacoes();
    }
}