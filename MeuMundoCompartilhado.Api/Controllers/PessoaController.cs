using MeuMundoCompartilhado.Domain.Entities;
using MeuMundoCompartilhado.Domain.Repositories;
using MeuMundoCompartilhado.Infra.Contexts;
using MeuMundoCompartilhado.Infra.Repositories;
using MeuMundoCompartilhado.Shared.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuMundoCompartilhado.Api.Controllers
{
    [ApiController]
    [Route("pessoa")]
    public class PessoaController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAll([FromServices] IUnitOfWork unitOfWork, [FromServices] IPessoaRepository pessoaRepository)
        {
            //TODO: Aqui terá o serviço
            //var pessoas = pessoaRepository.GetAll();
            //var posts = await context.Posts.Include(x => x.Author).ToListAsync();
            //return Ok(posts);
        }
    }
}
