using Microsoft.AspNetCore.Mvc;
using ProjetoIntegradorFinal.Models;
 
namespace ProjetoIntegradorFinal.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AvaliacaoController : ControllerBase
    {
        private BDContexto contexto;
 
        public AvaliacaoController(BDContexto bdContexto)
        {
            contexto = bdContexto;
        }
 
        [HttpGet]
        public List <Avaliacao> Listar()
        {
            return contexto.Avaliacaos.ToList();
        }

        [HttpGet]
        public List <string> ListarAvaliacao()
        {   
            var consultaAvaliacao = (from Avaliacao in contexto.Avaliacaos select Avaliacao.CComentario ).Distinct().ToList();

            return consultaAvaliacao;
        }
         [HttpPost]
        public string Avaliar([FromBody] Avaliacao novoAvaliacao)
        {
            contexto.Add(novoAvaliacao);
            contexto.SaveChanges();
            return "Sua opinão é muito importante para nós Obrigado";
        }
    }
    
}




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using ProjetoIntegradorFinal.Models;

// namespace ProjetoIntegradorFinal.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class AvaliacaoController : ControllerBase
//     {
//         private BDContexto contexto;
 
//         public AvaliacaoController(BDContexto bdContexto)
//         {
//             contexto = bdContexto;
//         }
//         [HttpGet]
//         public List <Avaliacao> Listar()
//         {
//             return contexto.Avaliacaos.ToList();
//         }
        
 
//         [HttpPost]
//         public string Avaliacao([FromBody] Avaliacao novoAvaliacao)
//         {
//             contexto.Add(novoAvaliacao);
//             contexto.SaveChanges();
//             return "Sua opinão é muito importante para nós Obrigado";
//         }

//         [HttpGet]
//         public List <string> ListarAvaliacao()
//         {   
//             var consultaAvaliacao = (from Avaliacao in contexto.Avaliacaos select Avaliacao.CNomeDisci).Distinct().ToList();

//             return consultaAvaliacao;
//         }
//     }
// }