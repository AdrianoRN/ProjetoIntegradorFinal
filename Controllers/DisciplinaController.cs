using Microsoft.AspNetCore.Mvc;
using ProjetoIntegradorFinal.Models;
 
namespace ProjetoIntegradorFinal.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private BDContexto contexto;
 
        public DisciplinaController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
 
        [HttpGet]
        public List <Disciplina> Listar()
        {
            return contexto.Disciplinas.ToList();
        }

        [HttpGet]
        public List <string> ListarDisciplina()
        {   
            var consultaDisciplina = (from Disciplina in contexto.Disciplinas select Disciplina.CNomeDisci).Distinct().ToList();

            return consultaDisciplina;
        }
    }
}
