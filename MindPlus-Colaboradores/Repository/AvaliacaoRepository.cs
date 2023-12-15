using Dapper;
using MindPlus_Colaboradores.Contracts.Repository;
using MindPlus_Colaboradores.DTO;
using MindPlus_Colaboradores.Entity;
using MindPlus_Colaboradores.Infrastructure;

namespace MindPlus_Colaboradores.Repository
{
    public class AvaliacaoRepository : Connection, IAvaliacaoRepository
    {
        public async Task RealizarAvaliacao(AvaliacaoDTO avaliacao)
        {
            string sql = @"
                    UPDATE AVALIACAO
                    SET resposta1 = @resposta1,
                        resposta2 = @resposta2,
                        resposta3 = @resposta3,
                        resposta4 = @resposta4,
                        resposta5 = @resposta5
                    WHERE ID = @COLABORADOR_ID
            ";
            await Execute(sql, avaliacao);
        }

        public async Task<IEnumerable<AvaliacaoEntity>> VisualizarAvaliacoes()
        {
            string  sql = @"SELECT * FROM AVALIACAO";
            return await GetConnection().QueryAsync<AvaliacaoEntity>(sql);
        }
    }
}