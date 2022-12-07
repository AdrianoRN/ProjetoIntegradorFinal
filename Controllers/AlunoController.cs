using Microsoft.AspNetCore.Mvc;
using ProjetoIntegradorFinal.Models;
 
namespace ProjetoIntegradorFinal.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private BDContexto contexto;
 
        public AlunoController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
 
        [HttpGet]
        public List<Aluno> Listar()
        {
            return contexto.Alunos.ToList();
        }
    }
}
