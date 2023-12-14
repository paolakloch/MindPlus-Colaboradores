using MindPlus_Colaboradores.DTO;
using MindPlus_Colaboradores.Entity;

namespace MindPlus_Colaboradores.Contracts.Repository
{
    public interface IColaboradorRepository
    {
        Task CadastrarColaborador(ColaboradorDTO colaborador);
        Task AtualizarColaborador(ColaboradorEntity colaborador);
        Task RemoverColaborador(int id);
        Task<IEnumerable<ColaboradorEntity>> VisualizarColaboradores();
    }
}
