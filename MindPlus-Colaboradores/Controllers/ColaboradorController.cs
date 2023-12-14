using Microsoft.AspNetCore.Mvc;
using MindPlus_Colaboradores.Contracts.Repository;
using MindPlus_Colaboradores.DTO;
using MindPlus_Colaboradores.Entity;

namespace MindPlus_Colaboradores.Controllers
{
    [ApiController]
    [Route("colaborador")]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorController(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> VisualizarColaboradores()
        {
            return Ok(await _colaboradorRepository.VisualizarColaboradores());
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarColaborador(ColaboradorDTO colaborador)
        {
            await _colaboradorRepository.CadastrarColaborador(colaborador);
            return Ok("Colaborador cadastrado com sucesso.");
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarColaborador(ColaboradorEntity colaborador)
        {
            await _colaboradorRepository.AtualizarColaborador(colaborador);
            return Ok("Colaborador atualizado com sucesso.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoverColaborador(int id)
        {
            await _colaboradorRepository.RemoverColaborador(id);
            return Ok("Colaborador removido com sucesso.");
        }
    }
}