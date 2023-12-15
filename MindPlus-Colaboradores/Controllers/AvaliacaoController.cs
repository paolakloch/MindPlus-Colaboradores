using Microsoft.AspNetCore.Mvc;
using MindPlus_Colaboradores.Contracts.Repository;
using MindPlus_Colaboradores.DTO;
using MindPlus_Colaboradores.Entity;
using MindPlus_Colaboradores.Repository;

namespace MindPlus_Colaboradores.Controllers
{
    
        [ApiController]
        [Route("avaliacao")]
        public class AvaliacaoController : ControllerBase
        {
            private readonly IAvaliacaoRepository _avaliacaoRepository;

            public AvaliacaoController(IAvaliacaoRepository avaliacaoRepository)
            {
                _avaliacaoRepository = avaliacaoRepository;
            }

            [HttpPost]
            public async Task<IActionResult> RealizarAvaliacao(AvaliacaoDTO avaliacao)
            {
                await _avaliacaoRepository.RealizarAvaliacao(avaliacao);
                return Ok("Avaliação realizada com sucesso.");
            }

            [HttpGet]
            public async Task<IActionResult> VisualizarAvaliacao()
            {
                return Ok(await _avaliacaoRepository.VisualizarAvaliacoes());
            }
        }
}
